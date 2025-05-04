using UnityEngine;

namespace Gameplay.Core
{
    public interface IInputSystem
    {
        bool Enabled { get; }
        bool PerformSelection { get; }
        Vector3 DownPosition { get; }
        Vector3 UpPosition { get; }
        void Enable();
        void Disable();
    }
}