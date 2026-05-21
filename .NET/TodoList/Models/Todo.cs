namespace TodoList.Models;

public class Todo
{
    public int id { get; set; }
    public string? iteam { get; set; }
    public bool itemStatus { get; set; }
    public DateTime createdAt { get; set; }

}