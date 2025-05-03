using Unity.Collections;
using Unity.Entities;

namespace Gameplay.Core
{
    public struct UnitCreationRequest : IComponentData
    {
        public NativeQueue<int> Request;
    }
}