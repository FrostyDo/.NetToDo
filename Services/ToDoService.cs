using sdani.Models;

namespace sdani.Services;

public class ToDoService {    ////////  Test with XUnit!!!!
    private static List<ToDo> ToDos = new ();
    
    public void AddToDo(string title, string discription)
    {
        ToDo todo = new (Guid.NewGuid(), title, discription);
        ToDos.Add(todo);
    }
    
    public void DeliteToDo(Guid id)
    {
        ToDos = ToDos.Where(todo => todo.id != id).ToList();
    }
    
    public ToDo? GetToDo(Guid id)
    {
        return ToDos.Find(todo => todo.id == id);
    }
    
    public List<ToDo> ToList()
    {
        return ToDos;
    }
}