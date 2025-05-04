using UnityEngine;

namespace Gameplay.Core
{
    public interface ICameraProvider
    {
        Camera Camera { get; }
        void SetCamera(Camera camera);
        bool IsValid();
    }
}