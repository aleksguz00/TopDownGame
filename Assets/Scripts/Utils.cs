using UnityEditor;
using UnityEngine;

namespace Game.Utils
{
    public static class GameUtils
    {
        public static Vector3 GetRandomDirection()
        {
            return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        }
    }
}