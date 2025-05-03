using Gameplay.Extensions;
using UnityEngine;

namespace Gameplay.Core
{
    [CreateAssetMenu(fileName = nameof(UnitConfig), menuName = "Configs/Core/Unit")]
    public sealed class UnitConfig : BaseScriptableObject<UnitData> { }
}