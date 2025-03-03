public class Event
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; }
}
