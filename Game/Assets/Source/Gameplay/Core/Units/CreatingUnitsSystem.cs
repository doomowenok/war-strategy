using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Gameplay.Core
{
    public partial struct CreatingUnitsSystem : ISystem
    {
        private int _count;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<UnitConfigComponent>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var config = SystemAPI.GetSingleton<UnitConfigComponent>();
            EntityCommandBuffer ecb = new EntityCommandBuffer(Allocator.TempJob);

            var job = new CreateUnitsJob()
            {
                Ecb = ecb,
                Position = new float3(1.0f, 1.0f, 1.0f) * _count++,
                Prefab = config.Prefab
            };
            
            state.Dependency = job.Schedule(state.Dependency);
            state.Dependency.Complete();

            ecb.Playback(state.EntityManager);
            ecb.Dispose();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }
    }

    [BurstCompile]
    public partial struct CreateUnitsJob : IJobEntity
    {
        public Entity Prefab;
        public EntityCommandBuffer Ecb;
        public float3 Position;

        [BurstCompile]
        public void Execute(in UnitCreationRequest request)
        {
            var entity = Ecb.Instantiate(Prefab);
            Ecb.SetComponent(entity, new LocalTransform()
            {
                Position = Position,
                Rotation = quaternion.identity,
                Scale = 1.0f
            });
        }
    }
}