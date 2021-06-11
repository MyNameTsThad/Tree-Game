using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public RectTransform slot;
    public Canvas canvas;
    public CanvasGroup canvasGroup;
    public RectTransform[] slotTarget = new RectTransform[2];

    Vector2 chachedPos;
    private void Start()
    {
        chachedPos = GetComponent<RectTransform>().anchoredPosition;
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        

        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
        
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        slot.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if (GetComponent<RectTransform>().position != slotTarget[0].position)
        {
            if (GetComponent<RectTransform>().position != slotTarget[1].position)
            {
               
               GetComponent<RectTransform>().anchoredPosition = chachedPos;
                                            
                                        
               
            }
        }
        
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("yey");
    }
}

