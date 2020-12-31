using BlazorStart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStart.Pages
{
    public partial class ToDo
    {
        private string newTodo;
        private IList<TodoItem> todos = new List<TodoItem>();

        protected override void OnInitialized()
        {
            todos.Add(new TodoItem() { Title = "Shopping", IsDone = false });
            todos.Add(new TodoItem() { Title = "Call", IsDone = true });
        }

        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
