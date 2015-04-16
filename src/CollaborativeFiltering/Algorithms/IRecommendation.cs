using System.Collections.Generic;

namespace CollaborativeFiltering
{
    public interface IRecommendation
    {
        IRating RecommendSubject(IRater rater, ISubject subject);

        IEnumerable<IRating> RecommendSubjects(IRater rater, IEnumerable<ISubject> subjects, int take = -1, int skip = 0);

        void AddRating(IRating rating);
    }
}
