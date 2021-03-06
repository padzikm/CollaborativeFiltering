﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFiltering.Evaluations
{
    public class EvaluatorsProvider : IEvaluatorsProvider
    {
        public List<IEvaluator> GetEvaluators()
        {
            var evaluators =  new List<IEvaluator>();
            evaluators.Add(new MeanAbsoluteErrorEvaluator());
            evaluators.Add(new RootMeanSquareErrorEvaluator());
            evaluators.Add(new AvarageRaterMeanAbsoluteErrorEvaluator());
            evaluators.Add(new TopListSignificancyEvaluator());
            evaluators.Add(new TopListAccuracyEvaluator());
            evaluators.Add(new TopListRelevancyEvaluator());

            return evaluators;
        }
    }
}
