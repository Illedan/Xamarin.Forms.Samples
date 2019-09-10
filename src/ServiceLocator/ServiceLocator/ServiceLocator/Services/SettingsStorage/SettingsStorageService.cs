using System.Threading.Tasks;
using ServiceLocator.Pages.Settings;
using Xamarin.Essentials;

namespace ServiceLocator.Services.SettingsStorage
{
    public class SettingsStorageService : ISettingsStorageService
    {
        private const string m_preferencesMockBool = "mock_mode";

        public Task Initialize(ISettingsModel model)
        {
            model.MockMode = Preferences.Get(m_preferencesMockBool, false);
            return Task.CompletedTask;
        }

        public Task Save(ISettingsModel model)
        {
            Preferences.Set(m_preferencesMockBool, model.MockMode);
            return Task.CompletedTask;
        }
    }
}
