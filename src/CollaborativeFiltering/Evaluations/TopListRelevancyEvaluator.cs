﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public class TopListRelevancyEvaluator : BaseEvaluator
    {
        public TopListRelevancyEvaluator()
            : base("Top list relevancy evaluation")
        {

        }

        public override double CalculateError(IRecommendation recommendation, IEnumerable<IRating> ratings, IEnumerable<IRater> raters, IEnumerable<ISubject> subjects)
        {
            var error = 0.0;

            foreach (var rater in raters)
            {
                var topList = recommendation.RecommendSubjects(rater, subjects, 0, 10);

                foreach (var result in ratings)
                {
                    if (!topList.Any(r => r.Subject == result.Subject && r.Rater == result.Rater))
                        error += 1.0;
                }
            }

            return error;
        }
    }
}
