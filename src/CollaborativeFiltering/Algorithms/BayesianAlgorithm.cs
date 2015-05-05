using MicrosoftResearch.Infer;
using MicrosoftResearch.Infer.Distributions;
using MicrosoftResearch.Infer.Factors;
using MicrosoftResearch.Infer.Maths;
using MicrosoftResearch.Infer.Models;
using MicrosoftResearch.Infer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Algorithms
{
    public class BayesianAlgorithm : IRecommendation
    {
        private IEnumerable<IRating> ratings;

        public BayesianAlgorithm(IEnumerable<IRating> _ratings)
        {
            ratings = _ratings;
        }

        public VariableArray<double> BayesPointMachine(double[] raters, double[] subjects, VectorGaussian WPosterior)
        {
            var w = Variable.Random(WPosterior);
            var yTest = Variable.Array<double>(new Range(subjects.Length));

            Range j = yTest.Range;
            var xData = new Vector[raters.Length];
            for (int i = 0; i < xData.Length; ++i)
                xData[i] = Vector.FromArray(raters[i], subjects[i], 1);

            VariableArray<Vector> x = Variable.Observed(xData, j);
            double noise = 0.1;
            yTest[j] = Variable.GaussianFromMeanAndVariance(Variable.InnerProduct(w, x[j]), noise);
            return yTest;
        }

        public IRating RecommendSubject(IRater rater, ISubject subject)
        {
            var raters = ratings.Select(r => r.Rater.Id).ToArray();
            var subjects = ratings.Select(r => r.Subject.Id).ToArray();
            var rates = ratings.Select(r => r.Value).ToArray();

            Vector[] xData = new Vector[raters.Length];
            for (int i = 0; i < xData.Length; ++i)
                xData[i] = Vector.FromArray(raters[i], subjects[i], 1);

            VariableArray<Vector> x = Variable.Observed(xData);
            var Y = Variable.Observed(rates, x.Range);
            Variable<Vector> w = Variable.Random(new VectorGaussian(Vector.Zero(3), PositiveDefiniteMatrix.Identity(3)));
            Range j = Y.Range;
            double noise = 0.1;
            Y[j] = Variable.GaussianFromMeanAndVariance(Variable.InnerProduct(w, x[j]), noise);

            var Engine = new InferenceEngine(new ExpectationPropagation());
            var WPosterior = Engine.Infer<VectorGaussian>(w);

            double [] ratersTest = new double[1];
            ratersTest[0] = rater.Id;
            double [] subjectsTest = new double[1];
            subjectsTest[0] = subject.Id;

            var yTest = BayesPointMachine(ratersTest, subjectsTest, WPosterior);
            var pred = Engine.Infer<DistributionStructArray<Gaussian, double>>(yTest);

            return new SimpleRating(rater, subject, pred[0].Point);
        }

        public IEnumerable<IRating> RecommendSubjects(IRater rater, IEnumerable<ISubject> subjects, int take = -1, int skip = 0)
        {
            var raters = ratings.Select(r => r.Rater.Id).ToArray();
            var subjectsInit = ratings.Select(r => r.Subject.Id).ToArray();
            var rates = ratings.Select(r => r.Value).ToArray();

            Vector[] xData = new Vector[raters.Length];
            for (int i = 0; i < xData.Length; ++i)
                xData[i] = Vector.FromArray(raters[i], subjectsInit[i], 1);

            VariableArray<Vector> x = Variable.Observed(xData);
            var Y = Variable.Observed(rates, x.Range);
            Variable<Vector> w = Variable.Random(new VectorGaussian(Vector.Zero(3), PositiveDefiniteMatrix.Identity(3)));
            Range j = Y.Range;
            double noise = 0.1;
            Y[j] = Variable.GaussianFromMeanAndVariance(Variable.InnerProduct(w, x[j]), noise);

            var Engine = new InferenceEngine(new ExpectationPropagation());
            var WPosterior = Engine.Infer<VectorGaussian>(w);

            var subjectsArray = subjects.ToArray();

            var ratersTest = Enumerable.Repeat((double)rater.Id, subjectsArray.Length).ToArray();
            var subjectsIdsTest = subjects.Select(s => (double)s.Id).ToArray();

            var yTest = BayesPointMachine(ratersTest, subjectsIdsTest, WPosterior);
            var pred = Engine.Infer<DistributionStructArray<Gaussian, double>>(yTest);

            var results = new List<IRating>();
            for (int i = 0; i < subjectsArray.Length; ++i)
                results.Add(new SimpleRating(rater, subjectsArray[i], pred[i].Point));

            return results.OrderBy(r => r.Value).Skip(skip).Take(take);
        }

        public void AddRating(IRating rating)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Bayesian network";
        }
    }
}
