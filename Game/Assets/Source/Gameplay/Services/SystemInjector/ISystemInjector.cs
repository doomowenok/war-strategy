using Unity.Entities;

namespace Gameplay.Services
{
    public interface ISystemInjector
    {
        void InjectSystem(ComponentSystemBase system);
    }
}