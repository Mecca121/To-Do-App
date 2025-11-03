using System.ComponentModel.DataAnnotations;

    namespace ToDoApp.Models
    {
        public class ToDoItem
        {
            // Primary Key for the database
            public int Id { get; set; }

            // The task description (Required/Validation is key here)
            [Required(ErrorMessage = "Please enter a task description.")]
            public string Title { get; set; }

            // Status of the task
            public bool IsCompleted { get; set; } = false;

            // Optional: Date when the task was created
            public DateTime CreatedDate { get; set; } = DateTime.Now;
        }
    }
