using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceLocator.Pages.Todo;

namespace ServiceLocator.Services.Todo
{
    public class TodoService : ITodoService
    {
        // TODO: Add device storage of items.

        public Task Add(TodoModel todoModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TodoModel todoModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoModel>> Get(bool isDone)
        {
            throw new NotImplementedException();
        }

        public Task Update(TodoModel todoModel)
        {
            throw new NotImplementedException();
        }
    }
}
