using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
using TodoList.Models;
using TodoList.DTO;
namespace TodoList.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{


    private readonly TodoService _service;
    public TodoController(TodoService service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Greeting(string user)
    {
        // Console.Write("Enter your UserName : ");
        // var user = Console.ReadLine() ?? "";
        var message = _service.Greeting(user);
        return Ok(message);
    }
    [HttpPost("/addTask")]
    public IActionResult AddTask(TodoDto todo)
    {
        var message = _service.AddTask(todo);
        return Ok(message);
    }
    [HttpGet("/allTask")]
    public IActionResult ShowAll()
    {
        var task = _service.ShowAll();
        return Ok(task);
    }

    [HttpDelete("delete/{id}")]
    public IActionResult DeleteByID(int id)
    {
        var message = _service.DeleteByID(id);
        return Ok(message);
    }

}