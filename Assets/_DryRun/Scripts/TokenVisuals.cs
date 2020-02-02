using UnityEngine;

namespace DryRun
{
    [CreateAssetMenu(menuName = "Token Visuals")]
    public class TokenVisuals : ScriptableObject
    {
        #region Fields
        public Material material = null;
        public Color color = Color.white;
        #endregion
    }
}