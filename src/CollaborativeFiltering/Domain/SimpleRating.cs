using System;
using System.Globalization;
namespace CollaborativeFiltering
{
    internal class SimpleRating : IRating
    {
        public IRater Rater { get; private set; }


        public ISubject Subject { get; private set; }


        public double Value { get; private set; }


        public SimpleRating(IRater rater, ISubject subject, double value)
        {
            Rater = rater;
            Subject = subject;
            Value = value;
        }

        public override string ToString()
        {
            return Subject.ToString() + " - " + Math.Round(Value, 4).ToString(CultureInfo.InvariantCulture);
        }
    }
}
