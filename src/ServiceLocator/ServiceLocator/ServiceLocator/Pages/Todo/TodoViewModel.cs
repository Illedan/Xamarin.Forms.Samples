using System;
using System.ComponentModel;
using ServiceLocator.Extensions;

namespace ServiceLocator.Pages.Todo
{
    public class TodoViewModel : INotifyPropertyChanged
    {
        private readonly TodoModel m_todoModel;

        public TodoViewModel(TodoModel todoModel)
        {
            m_todoModel = todoModel;
        }

        public string Title
        {
            get => m_todoModel.Title;
            set
            {
                m_todoModel.Title = value;
                this.OnPropertyChanged(PropertyChanged, nameof(Title));
            }
        }

        public

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
