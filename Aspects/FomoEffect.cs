public class FomoEffect{
    [Advice(Target = AdviceTarget.Participant)]
    public void ApplyFomo(Person person, List<OpenSpaceSession> parallelSessions)
    {
        if (parallelSessions.Count > 1)
        {
            person.MightFeelFomo = true;
        }
    }
}

[Aspect]