using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Token : MonoBehaviour, IPointerDownHandler
{
    #region Fields
    public int health = 1;
    #endregion

    #region Methods
    public void OnPointerDown(PointerEventData eventData)
    {
        --health;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
