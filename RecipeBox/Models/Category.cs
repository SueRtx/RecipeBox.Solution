using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }
    public string Name { get; set; }
    public int CategoryId { get; set; }

    public virtual ICollection<CategoryRecipe> JoinEntities { get; set; }
    public virtual ApplicationUser User { get; set; }   
  }
}