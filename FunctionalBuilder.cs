internal class FunctionalBuilder<TSubject, TSelf> 
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : class, new()
{
    private readonly List<Func<TSubject, TSubject>> _actions = new();

    private TSelf AddAction(Action<TSubject> action)
    {
        _actions.Add(subject =>
        {
            action(subject);
            return subject;
        });

        return (TSelf)this;
    }

    public TSelf Do(Action<TSubject> action) => AddAction(action);

    public TSubject Build() => _actions.Aggregate(new TSubject(), (subject, func) => func(subject));
}

