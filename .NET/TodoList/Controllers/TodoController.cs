using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
namespace TodoList.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{


    private readonly TodoService _service;
    public TodoController(TodoService service)
    {
        service = _service;
    }
    [HttpGet]
    public IActionResult Greeting()
    {
        Console.Write("Enter your UserName : ");
        var user = Console.ReadLine();
        var message = _service.Greeting(user);
        return Ok(message);
    }

}