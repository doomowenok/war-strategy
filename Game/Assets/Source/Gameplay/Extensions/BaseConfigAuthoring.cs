using UnityEngine;

namespace Gameplay.Extensions
{
    public abstract class BaseConfigAuthoring<TConfig> : MonoBehaviour
    {
        public TConfig Config;
    }
}