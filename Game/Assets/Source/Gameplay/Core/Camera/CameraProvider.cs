using UnityEngine;

namespace Gameplay.Core
{
    public sealed class CameraProvider : ICameraProvider
    {
        public Camera Camera { get; private set; }

        public void SetCamera(Camera camera)
        {
            Camera = camera;
        }

        public bool IsValid()
        {
            return Camera != null;
        }
    }   
}