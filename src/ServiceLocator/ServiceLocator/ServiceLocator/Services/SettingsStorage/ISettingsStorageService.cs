using System;
using System.Threading.Tasks;
using ServiceLocator.Pages.Settings;

namespace ServiceLocator.Services.SettingsStorage
{
    public interface ISettingsStorageService
    {
        Task Initialize(ISettingsModel model);

        Task Save(ISettingsModel model);
    }
}
