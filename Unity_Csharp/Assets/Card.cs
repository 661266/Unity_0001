using UnityEngine;
using UnityEngine.EventSystems; //引用 事件API -拖拉介面

public class Card : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private Vector3 pos;
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("開始拖拉了");
        pos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉中");
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("拖拉結束");
        transform.position = pos;
    }



}
