﻿using System.Collections.Generic;
using HelloBlazor.Shared;

namespace HelloRazor.App.Pages
{
    public partial class Todo
    {
        private IList<TodoItem> todos = new List<TodoItem>();
        private string newTodo;

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
