﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //ventData.pointerDrag.name é o objeto que vc está arrastando
        //gameObject.name é o objeto que possúi o script DropZone
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Card c = eventData.pointerDrag.GetComponent<Card>();
        if (c != null) c.parentToReturnTo = transform;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }
}
