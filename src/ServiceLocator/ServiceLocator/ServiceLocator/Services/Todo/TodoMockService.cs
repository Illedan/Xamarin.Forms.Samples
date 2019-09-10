using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLocator.Pages.Todo;

namespace ServiceLocator.Services.Todo
{
    public class TodoMockService : ITodoService, IMockService<ITodoService>
    {
        private List<TodoModel> m_models = new List<TodoModel>
        {
            new TodoModel{ Id = 0, IsDone = false, Title = "Mock item 0"},
            new TodoModel{ Id = 1, IsDone = false, Title = "Mock item 1"},
            new TodoModel{ Id = 2, IsDone = false, Title = "Mock item 2"},
            new TodoModel{ Id = 3, IsDone = true, Title = "Done mock item 3"}
        };

        public ITodoService Instance => this;

        public Task<TodoModel> Add(TodoModel todoModel)
        {
            todoModel.Id = m_models.Max(m => m.Id) + 1;
            m_models.Add(todoModel);
            return Task.FromResult(todoModel);
        }

        public Task Delete(TodoModel todoModel)
        {
            m_models.RemoveAll(m => m.Id == todoModel.Id);
            return Task.CompletedTask;
        }

        public Task<List<TodoModel>> Get(bool isDone)
        {
            return Task.FromResult(m_models.Where(m => m.IsDone == isDone).ToList());
        }

        public Task Update(TodoModel todoModel)
        {
            // Already updated in the model.
            return Task.CompletedTask;
        }
    }
}
