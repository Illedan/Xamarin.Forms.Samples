using System;
namespace ServiceLocator.Services.Locator
{
    public interface IServiceLocator<T> where T : class
    {
        T GetService();
    }
}
