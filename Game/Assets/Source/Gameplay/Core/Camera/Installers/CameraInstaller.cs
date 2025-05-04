using VContainer;
using VContainer.Unity;

namespace Gameplay.Core
{
    public sealed class CameraInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<CameraProvider>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}