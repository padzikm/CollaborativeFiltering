namespace CollaborativeFiltering
{
    public interface IRating
    {
        IRater Rater { get; }

        ISubject Subject { get; }

        double Value { get; }
    }
}
