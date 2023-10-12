using Microsoft.AspNetCore.Mvc;
using sdani.Models;
using sdani.Services;


namespace sdani.Controllers;


[ApiController]
[Route("ToDos")]
public class ToDoController {
    private static readonly List<ToDo> ToDos = new ();
    
    [HttpPost]
    public void PostString(ToDo todo)
    {
        ToDos.Add(todo);
    }
    
    [HttpGet("/something")]
    public Guid GetString()
    {
        return Guid.NewGuid();
    }
}