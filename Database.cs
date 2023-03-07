using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Todo
{
    public sealed class Todo
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public bool IsCompleted { get; private set; }
        public Todo(string title, string content)
        {
            Title = title;
            Content = content;
        }

    }

    public sealed class Database : DbContext
    {
        public static readonly Database Instance = new Database();
        public DbSet<Todo> Todos => Set<Todo>();

       

        public Database()
        {
            
            
            Database.EnsureCreated();
            var todoHomeWor = new Todo("Homework", "Make your home work");
            TryAdd(todoHomeWor);
            var todoClean = new Todo("Clean", "You have to clean your room");
            TryAdd(todoClean);


        }
        public void TryAdd(Todo newTodo)
        {
            var todos = Todos.ToList();
            var doesExist = todos.Any(todo=>todo.Title==newTodo.Title);
            if (doesExist)
                return;
            Todos.Add(newTodo);
            Instance.SaveChanges();
            
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder oprtions)
        {
          
            oprtions.UseSqlite("Data Source =todos.db");
        }
    }
}
