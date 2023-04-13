
using Entities.Context;
using Entities.Models;
using Repository.RepositoryInterfaces;

namespace Repository
{
    public class ToDoItemRepository : RepositoryBase<ToDoItem>, IToDoItemRepository
    {
        public ToDoItemRepository(ToDoListDbContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}
