using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreToDoList.Services;
using ASPCoreToDoList.Models;

namespace ASPCoreToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;
        // GET: /<controller>/
        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }
        public async Task<IActionResult> Index()
        {
            var toDoItems = await _toDoItemService.GetIncompleteItemsAsync();
            var model = new ToDoViewModel(){ Items = toDoItems };
            return View(model);
        }
        public async Task<IActionResult> AddItem(NewToDoItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var successful = await _toDoItemService.AddItemAsync(newItem);
            if (!successful)
            {
                return BadRequest(new { error = "Could not add item" });
            }
            return Ok();
        }
    }
}
