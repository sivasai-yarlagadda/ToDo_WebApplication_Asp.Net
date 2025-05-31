using System.ComponentModel.DataAnnotations;

namespace ToDoListWebApplication.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }


    }

}
