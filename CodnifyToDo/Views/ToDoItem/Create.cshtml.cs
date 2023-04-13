using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodnityToDo.Views.ToDoItem
{
    public class CreateModel : PageModel
    {
        public Entities.Models.ToDoItem ToDoItem { get; set; } = null!;
        public void OnGet()
        {
        }
    }
}
