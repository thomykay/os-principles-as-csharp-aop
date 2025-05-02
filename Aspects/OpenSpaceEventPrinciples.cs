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