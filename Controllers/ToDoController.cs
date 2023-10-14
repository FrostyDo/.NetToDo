using Microsoft.AspNetCore.Mvc;
using sdani.Models;
using sdani.Services;


namespace sdani.Controllers;


[ApiController]
[Route("ToDo_List")]
public class ToDoController
{
    //private readonly ToDoService _toDoService = new ();
    
    private readonly ToDoService _toDoService;

    public ToDoController(ToDoService toDoService)
    {
        _toDoService = toDoService;
    }


    [HttpPost]
    public void PostString(string title, string description)
    {
       _toDoService.AddToDo(title, description);
    }
    
    [HttpGet("/something")]
    public List<ToDo> GetString()
    {
         return _toDoService.ToList();
    }
}