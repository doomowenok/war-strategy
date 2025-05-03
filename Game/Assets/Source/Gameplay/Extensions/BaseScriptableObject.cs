using UnityEngine;

namespace Gameplay.Extensions
{
    public abstract class BaseScriptableObject<TConfigData> : ScriptableObject
    {
        public TConfigData Data;
    }
}