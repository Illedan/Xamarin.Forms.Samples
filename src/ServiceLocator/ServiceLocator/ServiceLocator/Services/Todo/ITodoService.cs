using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceLocator.Pages.Todo;

namespace ServiceLocator.Services.Todo
{
    public interface ITodoService
    {
        Task<List<TodoModel>> Get(bool isDone);
        Task<TodoModel> Add(TodoModel todoModel);
        Task Update(TodoModel todoModel);
        Task Delete(TodoModel todoModel);
    }
}
