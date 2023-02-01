namespace MvcToDoList.Models;

public class ToDo
{
    public int Id { get; set; }
    public String Name { get; set; } = String.Empty;
    public DateTime DateAdded { get; set; } = DateTime.Now;
}
