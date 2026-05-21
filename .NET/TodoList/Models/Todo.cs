namespace TodoList.Models;

public class Todo
{
    public int Id { get; set; }
    public string? Item { get; set; }
    public bool ItemStatus { get; set; }
    public DateTime CreatedAt { get; set; }

}