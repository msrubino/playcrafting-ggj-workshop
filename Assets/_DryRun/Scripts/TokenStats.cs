using UnityEngine;

namespace DryRun
{
    [CreateAssetMenu(menuName = "Token Stats")]
    public class TokenStats : ScriptableObject
    {
        #region Fields
        public int health = 1;
        public Vector3 size = Vector3.one;
        #endregion
    }
}