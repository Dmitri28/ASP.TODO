using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Controllers
{
    public sealed class TodoController : Controller
    {
        public readonly List<Todo> _todos = new List<Todo>();
        public IActionResult Index()
        {
            var todoViewModel = new TodoViewModel();
            return View(todoViewModel);
        }
    }
}
