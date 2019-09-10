using ServiceLocator.Pages.Settings;

namespace ServiceLocator.Services.Locator
{
    public class ServiceLocator<T> : IServiceLocator<T> where T : class
    {
        private readonly ISettingsModel m_settingsModel;
        private readonly T m_service;
        private readonly T m_mockService;
        private readonly bool m_hasMockMode;

        public ServiceLocator(T service, IMockService<T> mockService, ISettingsModel settingsModel)
        {
            m_service = service;
            m_mockService = mockService.Instance;
            m_settingsModel = settingsModel;
            m_hasMockMode = true;
        }

        public ServiceLocator(T service)
        {
            m_hasMockMode = false;
            m_service = service;
        }

        public T GetService()
        {
            if (!m_hasMockMode) return m_service;
            return m_settingsModel.MockMode ? m_mockService : m_service;
        }
    }
}
