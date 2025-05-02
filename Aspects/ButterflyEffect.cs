public class ButterflyEffect{
    [Advice(Target = AdviceTarget.Participant)]
    public void ApplyButterflyBehavior(Person person)
    {
        if (person.Role == ParticipantRole.Butterfly)
        {
            Debug.Assert(person.IsLearning || person.IsContributing,
                $"{person.Name} as Butterfly must follow the Law of Two Feet.");
            person.SparkSerendipity();
        }
    }
}