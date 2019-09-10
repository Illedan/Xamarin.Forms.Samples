using System;
using ServiceLocator.Services.Locator;
using ServiceLocator.Services.Todo;

namespace ServiceLocator.Pages.Todo
{
    public class TodoPageViewModel
    {
        private readonly IServiceLocator<ITodoService> todoService;

        public TodoPageViewModel(IServiceLocator<ITodoService> todoService)
        {
            this.todoService = todoService;
        }

        public ObservableCollection<TodoMo>
    }
}
