using Unity.Entities;
using VContainer;

namespace Gameplay.Services
{
    public sealed class SystemInjector : ISystemInjector
    {
        private readonly IObjectResolver _container;

        public SystemInjector(IObjectResolver container)
        {
            _container = container;
        }

        public void InjectSystem(ComponentSystemBase system)
        {
            _container.Inject(system);
        }
    }
}