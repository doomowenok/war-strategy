using UnityEngine;
using VContainer.Unity;

namespace Gameplay.Core
{
    public sealed class InputSystem : ITickable, IInputSystem
    {
        public bool Enabled { get; private set; } = true;
        public Vector3 DownPosition { get; private set; }
        public Vector3 UpPosition { get; private set; }
        public bool PerformSelection { get; private set; }

        public void Enable()
        {
            Enabled = true;
        }

        public void Disable()
        {
            Enabled = false;
        }
        
        public void Tick()
        {
            if (!Enabled)
            {
                return;
            }

            if (Input.GetMouseButtonDown(0) && !PerformSelection)
            {
                PerformSelection = true;
                DownPosition = Input.mousePosition;
            }

            if (PerformSelection)
            {
                UpPosition = Input.mousePosition;
            }
            
            if (PerformSelection && Input.GetMouseButtonUp(0))
            {
                PerformSelection = false;
            }
        }
    }
}