public class BumblebeeEffect{
    [Advice(Target = AdviceTarget.Participant)]
    public void ApplyBumblebeeBehavior(Person person)
    {
        if (person.Role == ParticipantRole.Bumblebee)
        {
            Debug.Assert(person.IsLearning || person.IsContributing,
                $"{person.Name} as Bumblebee must follow the Law of Two Feet.");
            person.CrossPollinateIdeas();
        }
    }
}

[Aspect]