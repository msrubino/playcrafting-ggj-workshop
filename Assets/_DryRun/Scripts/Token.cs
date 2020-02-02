using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DryRun
{
    public class Token : MonoBehaviour, IPointerDownHandler
    {
        #region Events
        public delegate void DestroyedToken(TokenStats stats);

        public static event DestroyedToken DestroyedTokenEvent;
        #endregion

        #region Fields
        public TokenStats stats = null;
        public TokenVisuals visuals = null;
        public MeshRenderer[] meshRenderers = null;

        [NonSerialized] public int health = 1;
        #endregion

        #region Methods
        private void Awake()
        {
            health = stats.health;
            transform.localScale = stats.size;
            meshRenderers = GetComponentsInChildren<MeshRenderer>();
        }

        private void Start()
        {
            foreach (MeshRenderer meshRenderer in meshRenderers)
            {
                meshRenderer.material = visuals.material;
                meshRenderer.material.color = visuals.color;
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            --health;
            if (health == 0)
            {
                DestroyedTokenEvent?.Invoke(stats);
                Destroy(gameObject);
            }
        }
        #endregion
    }
}