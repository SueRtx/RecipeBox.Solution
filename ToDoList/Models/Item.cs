namespace ToDoList.Models
{
  public class Item
  {
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}