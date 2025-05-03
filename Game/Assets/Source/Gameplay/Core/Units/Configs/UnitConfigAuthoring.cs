using Gameplay.Extensions;
using Unity.Entities;

namespace Gameplay.Core
{
    public sealed class UnitConfigAuthoring : BaseConfigAuthoring<UnitConfig>
    {
        private class Baker : Baker<UnitConfigAuthoring>
        {
            public override void Bake(UnitConfigAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                
                AddComponent(entity, new UnitConfigComponent()
                {
                    Prefab = GetEntity(authoring.Config.Data.Prefab, TransformUsageFlags.Dynamic)
                });
            }
        }
    }
}