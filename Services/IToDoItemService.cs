using ASPCoreToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreToDoList.Services
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(NewToDoItem newItem);
        Task<bool> MarkDoneAsync(Guid id);
    }
}
