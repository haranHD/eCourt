using TodoList.Models;
using TodoList.DTO;
namespace TodoList.Services;

public class TodoService
{

    List<Todo> MainTodo = new List<Todo>();
    public string Greeting(string user)
    {
        return $"Hello {user}!";
    }

    public string AddTask(TodoDto todo)
    {

        var Task = new Todo
        {
            Id = MainTodo.Count + 1,
            Item = todo.Task,
            ItemStatus = false,
            CreatedAt = DateTime.Now
        };
        MainTodo.Add(Task);
        return "Task Added";
    }

    public List<Todo> ShowAll()
    {
        return MainTodo;
    }

    public string DeleteByID(int id)
    {
        var task = MainTodo.FirstOrDefault(t => t.Id == id);
        if (task == null)
            return "Task not found";
        MainTodo.Remove(task);
        return "Removed";
    }



}