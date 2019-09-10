using System;
namespace ServiceLocator.Services
{
    /// <summary>
    /// Implement this if the current service is a mock service. Used in Service Locator
    /// </summary>
    public interface IMockService<T> where T : class
    {
        T Instance { get; }
    }
}
