using System.ComponentModel;
using ServiceLocator.Extensions;

namespace ServiceLocator.Pages.Settings
{
    public class SettingsViewModel : ISettingsViewModel, INotifyPropertyChanged
    {
        private readonly ISettingsModel m_settingsModel;

        public SettingsViewModel(ISettingsModel settingsModel)
        {
            m_settingsModel = settingsModel;
        }

        public bool MockMode
        {
            get => m_settingsModel.MockMode;
            set
            {
                m_settingsModel.MockMode = value;
                this.OnPropertyChanged(PropertyChanged, nameof(MockMode));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
