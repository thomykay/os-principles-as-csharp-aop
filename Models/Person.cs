public class Person{
    public string Name { get; set; }
    public bool IsWilling { get; set; }
    public bool IsLearning { get; set; }
    public bool IsContributing { get; set; }
    public bool MightFeelFomo { get; set; }
    public ParticipantRole Role { get; set; }

    public bool IsHosting { get; set; }
    public bool IsBeingHosted { get; set; }
    public bool IsPartOfCommunity { get; set; }

    public void CrossPollinateIdeas() { }

    public void SparkSerendipity() { }

    public void HostSession(string topic)
    {
        IsHosting = true;
        Role = ParticipantRole.SessionHost;
        // Optionally log or prepare session
    }

    public void JoinAsParticipant()
    {
        IsBeingHosted = true;

        if (Role == ParticipantRole.Regular)
        {
            Role = ParticipantRole.SessionParticipant;
        }
    }

    public void ParticipateInCommunity()
    {
        IsPartOfCommunity = true;
    }
}