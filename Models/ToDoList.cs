using System.Collections.ObjectModel;

namespace MvcToDoList.Models;


//TODO Move Controller Function To Domain Model
public class ToDoList
{
    private List<ToDo> toDoList = new List<ToDo>();
    public ReadOnlyCollection<ToDo> GetList
    {
        get
        {
            return toDoList.AsReadOnly();
        }
    }

    public void AddItem(String name)
    {
        if (!String.IsNullOrWhiteSpace(name))
        {
            ToDo newItem = new ToDo() { Name = name };
            toDoList.Add(newItem);
        }

    }


}