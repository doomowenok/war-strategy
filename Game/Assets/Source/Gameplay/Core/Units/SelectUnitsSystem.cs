using Gameplay.Services;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Gameplay.Core
{
    public partial class SelectUnitsSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            IInputSystem inputSystem = ServiceLocator.Get<IInputSystem>();
            Camera camera = Camera.main;

            foreach (var entity in SystemAPI.Query<RefRO<Unit>, RefRO<LocalTransform>>())
            {
                Debug.Log(camera.WorldToScreenPoint(entity.Item2.ValueRO.Position));
            }
        }
    }
}