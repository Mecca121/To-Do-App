using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Services;

public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;

        // Constructor Injection (OOP Design)
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        // Read: Lists all To-Do items
        public async Task<IActionResult> Index()
        {
            var items = await _toDoService.GetAllAsync();
            return View(items); // Pass model data to the View
        }

        // Create (GET): Displays the 'Create' form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Create (POST): Handles form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ToDoItem item)
        {
            if (ModelState.IsValid) // Built-in data validation from Model
            {
                await _toDoService.AddAsync(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // ... Implement Edit and Delete actions similarly for full CRUD
    }
