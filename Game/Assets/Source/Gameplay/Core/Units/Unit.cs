using Unity.Entities;

namespace Gameplay.Core
{
    public struct Unit : IComponentData
    {
        
    }

    public struct UnitConfigComponent : IComponentData
    {
        public Entity Prefab;
    }
}