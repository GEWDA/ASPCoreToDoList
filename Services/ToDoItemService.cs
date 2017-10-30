﻿using ASPCoreToDoList.Data;
using ASPCoreToDoList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreToDoList.Services
{
    public class ToDoItemService : IToDoItemService
    {

        private readonly ApplicationDbContext _context;
        public ToDoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            return await _context.Items
            .Where(x => x.IsDone == false)
            .ToArrayAsync();
        }
        {
            var entity = new ToDoItem
            {
                Id = Guid.NewGuid(),
                IsDone = false,
                Title = newItem.Title,
                DueAt = DateTimeOffset.Now.AddDays(3)
            };
            _context.Items.Add(entity);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}