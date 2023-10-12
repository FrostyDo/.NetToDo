using sdani.Models;

namespace sdani.Services;

public class ToDoService {    ////////  Test with XUnit!!!!
    private static readonly List<ToDo> ToDos = new ();
    
    public void AddToDo(string title, string discription)
    {
        throw new NotImplementedException();
    }
    
    public void DeliteToDo(Guid id)
    {
        throw new NotImplementedException();
    }
    
    public ToDo? GetToDo(Guid id)
    {
        throw new NotImplementedException();
    }
    
    public List<ToDo> ToList()
    {
        throw new NotImplementedException();
    }
}