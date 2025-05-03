using VContainer;

namespace Gameplay.Services
{
    public sealed class ServiceLocatorRegistrator : IServiceLocatorRegistrator
    {
        private readonly IObjectResolver _container;

        public ServiceLocatorRegistrator(IObjectResolver container)
        {
            _container = container;
        }
        
        public void Register()
        {
            
        }
    }
}