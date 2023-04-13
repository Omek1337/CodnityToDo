using Entities.Context;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Repository
{

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ToDoListDbContext _context;
        private IToDoItemRepository _todoItem;

        public RepositoryWrapper(ToDoListDbContext context)
        {
            _context = context;
        }

        public IToDoItemRepository ToDoItem 
        {
            get
            {
                if (_todoItem == null)
                {
                    _todoItem = new ToDoItemRepository(_context);
                } 
                return _todoItem;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
