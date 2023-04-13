
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Entities.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = null!;
        [Display(Name = "Description")]
        [MaxLength(200)]
        public string Description { get; set; } = null!;
        [Display(Name = "Status")]
        public bool Status { get; set; }
        [Display(Name = "DeadlineDate")]
        public DateTime? DeadlineDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set;}
    }
}
