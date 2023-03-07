namespace Todo.Models
{
    public sealed class TodoViewModel
    {
        public readonly List<Todo> _todos = new List<Todo>();
       public TodoViewModel()
        {
            var todoViewModel = new TodoViewModel();
        }
    }
}
