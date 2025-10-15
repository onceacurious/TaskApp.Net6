namespace TaskApp.Net6.Models;

public class TaskItem
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public bool IsCompleted { get; set; } = false;
}