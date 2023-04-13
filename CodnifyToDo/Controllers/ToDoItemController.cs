using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.RepositoryInterfaces;
using System;

namespace CodnityToDo.Controllers
{
    public class ToDoItemController : Controller
    {
        private IRepositoryWrapper _repository;
        public ToDoItemController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        // GET: ToDoItemController
        public ActionResult Index(string name)
        {
            ViewBag.todos = _repository.ToDoItem.FindByCondition(x => x.UserName == name).ToList();
            return View();
        }

        // GET: ToDoItemController/GetTodos
        public ActionResult GetTodos()
        {
            return View();
        }

        // GET: ToDoItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDoItemController/Create
        public ActionResult Create(string name)
        {
            ViewBag.userName = name;
            return View();
        }

        // POST: ToDoItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ToDoItem todoItem)
        {
            try
            {
                _repository.ToDoItem.Create(new ToDoItem()
                {
                    Id = Guid.NewGuid(),
                    UserName = todoItem.UserName,
                    Description = todoItem.Description,
                    DeadlineDate = todoItem.DeadlineDate,
                    Created = DateTime.UtcNow,
                    Updated = DateTime.UtcNow,
                    Status  = todoItem.Status
                });
                _repository.Save();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoItemController/Edit/--
        public ActionResult Edit(Guid id)
        {
            ViewBag.todoItem = _repository.ToDoItem.FindByCondition(x => x.Id == id).FirstOrDefault();
            return View();
        }

        // POST: ToDoItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] ToDoItem todoItem)
        {
            try
            {

				_repository.ToDoItem.Update(new ToDoItem
                {
                    Id= todoItem.Id,
                    UserName = todoItem.UserName,
                    Description = todoItem.Description,
                    DeadlineDate = todoItem.DeadlineDate,
                    Created = todoItem.Created,
                    Updated = DateTime.UtcNow,
                    Status = todoItem.Status
                });
                _repository.Save();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoItemController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var item = _repository.ToDoItem.FindByCondition(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                _repository.ToDoItem.Delete(item);
                _repository.Save();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
