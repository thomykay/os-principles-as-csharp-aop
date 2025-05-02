public class SessionPrinciples{
    [Precondition]
    public void SessionMustHaveTopicAndHost(OpenSpaceSession session)
    {
        Debug.Assert(!string.IsNullOrWhiteSpace(session.Topic));
        Debug.Assert(session.Host != null);
    }

    [Postcondition]
    public void CaptureHarvest(OpenSpaceSession session)
    {
        Debug.Assert(session.Harvest != null,
            "Every session should leave behind a trace of what emerged."
            + " Capture reflections, surprises, decisions, or questions worth carrying forward.");
    }
}