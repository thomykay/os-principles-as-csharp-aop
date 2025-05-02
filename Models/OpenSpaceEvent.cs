public class OpenSpaceEventPrinciples
{
    [Precondition]
    public void WhoeverComesAreTheRightPeople(IEnumerable<Person> participants)
    {
        Debug.Assert(participants != null, "Participant list must not be null.");
        Debug.Assert(participants.All(p => p.IsWilling),
            "All participants must be willing — whoever comes are the right people.");
    }

    [Precondition]
    public void WheneverItStartsIsTheRightTime(DateTime actualStart)
    {
        Debug.Assert(actualStart != default);
    }

    [Invariant]
    public void WhateverHappensIsTheOnlyThingThatCouldHave()
    {
        Debug.Assert(true, "Accept the emergent. Be prepared to be surprised.");
    }

    [Postcondition]
    public void WhenItsOverItsOver(DateTime actualEnd)
    {
        Debug.Assert(actualEnd != default,
            "Sessions and events should end when the energy is complete."
            + " Reflect, appreciate, and let go. Consider what surprised or moved you.");
    }

    [Invariant]
    public void LawOfTwoFeet(Person p)
    {
        Debug.Assert(p.IsLearning || p.IsContributing,
            $"{p.Name} should move to where they can learn or contribute.");
    }
}

[Aspect]
public class FomoEffect
{
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
public class BumblebeeEffect
{
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
public class ButterflyEffect
{
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