using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTrans;
    private CanvasGroup canvasgroup;

    public GameObject Snippet, DropSpot;


    Vector2 InitialPos;

    private void Awake()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasgroup = Snippet.GetComponent<CanvasGroup>();
        InitialPos = Snippet.transform.position;
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasgroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasgroup.blocksRaycasts = true;
        if(Snippet.transform.position == DropSpot.transform.position)
        {
            canvasgroup.interactable = false;
            GameObject.Find("PointHandler").GetComponent<Win>().AddPoints();
        }
        else
        {
            Snippet.transform.position = InitialPos;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

}
