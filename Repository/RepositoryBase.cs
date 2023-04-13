using Entities.Context;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.RepositoryInterfaces;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ToDoListDbContext RepositoryContext { get; set; }

        public RepositoryBase( ToDoListDbContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll() => 
            RepositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            RepositoryContext.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity) => 
            RepositoryContext.Set<T>().Add(entity);

        public void Update(T entity) => 
            RepositoryContext.Set<T>().Update(entity);

        public void Delete(T entity) => 
            RepositoryContext.Set<T>().Remove(entity);
    }
}