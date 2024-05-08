using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 物体拖拽类
/// </summary>
public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    /// <summary>
    /// 物体的基本信息组件
    /// </summary>
    private RectTransform rectTrans;

    /// <summary>
    /// 物体的画布组件
    /// </summary>
    private CanvasGroup canvasGroup;

    void Start()

    {

        rectTrans = GetComponent<RectTransform>();
        FindObjectOfType<CanvasGroup>();
        if (canvasGroup == null)
            rectTrans.AddComponent<CanvasGroup>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    /// <summary>
    /// 拖拽过程函数
    /// </summary>
    /// <param name="eventData">鼠标信息</param>
    public void OnDrag(PointerEventData eventData)

    {

        rectTrans.anchoredPosition += eventData.delta;

        //获取这个UI图片相对于Anchor锚点的位置坐标信息

        //eventData.delta自从上一次Update，用户拖着这个对象所移动的2D位置坐标信息      

    }

    /// <summary>
    /// 拖拽起始函数
    /// </summary>
    /// <param name="eventData">鼠标信息</param>
    public void OnBeginDrag(PointerEventData eventData)

    {

        canvasGroup.blocksRaycasts = false;

        canvasGroup.alpha = 0.5f;

    }

    /// <summary>
    /// 拖拽结束函数
    /// </summary>
    /// <param name="eventData">鼠标信息</param>
    public void OnEndDrag(PointerEventData eventData)

    {

        canvasGroup.blocksRaycasts = true;

        canvasGroup.alpha = 1f;

    }
}