using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TasksWeb.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Title { get; set; } = string.Empty;
        [Required, StringLength(10)]
        public string Author { get; set; } = string.Empty;
        [Required, StringLength(30)]
        public string Content { get; set; } = string.Empty;
        [DisplayName("CreateDate")]
        public DateTime CreatedOn { get; set; }
    }
}
