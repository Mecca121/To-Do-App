using ToDoApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ToDoApp.Services
    {
        public interface IToDoService
        {
            // READ: Retrieves all ToDo items
            Task<IEnumerable<ToDoItem>> GetAllAsync();

            // READ: Retrieves a single ToDo item by ID
            Task<ToDoItem> GetByIdAsync(int id);

            // CREATE: Adds a new ToDo item to the store
            Task AddAsync(ToDoItem item);

            // UPDATE: Modifies an existing ToDo item
            Task UpdateAsync(ToDoItem item);

            // UPDATE: Toggles the completion status of a task
            Task ToggleCompleteAsync(int id);

            // DELETE: Removes a ToDo item by ID
            Task DeleteAsync(int id);
        }
    }
