using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodnityToDo.Views.ToDoItem
{
    public class EditModel : PageModel
    {
		public Entities.Models.ToDoItem ToDoItem { get; set; } = null!;
		public void OnGet()
        {
        }
    }
}
