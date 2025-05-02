public class OpenSpaceSession{
    public string Topic { get; set; }
    public Person Host { get; set; }
    public List<Person> Participants { get; set; }
    public object Harvest { get; set; }

    public void Run()
    {
        Host?.HostSession(Topic);
        foreach (var p in Participants)
        {
            p.ParticipateInCommunity();
        }
        StartConversation();
        Harvest = CaptureInsights();
    }

    private void StartConversation() { }

    private object CaptureInsights()
    {
        return new { Summary = "...", FollowUps = new List<string>() };
    }
}