using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

/// <summary>
/// 建筑Item类
/// </summary>
public class ArchitectureItem : ArchitectureConfigItem
{
    #region 建筑Item类字段
    [HideLabel]
    [LabelText("建筑Trans信息")]
    public RectTransform rectTrans;

    [HideLabel]
    [LabelText("拖拽组件")]
    public DragDrop dragDrop;

    [HideLabel]
    [LabelText("拖拽缩放组件")]
    public PointerDragDragUIToResize dragUIToResize;
    #endregion

    #region 建筑Item类函数
    /// <summary>
    /// 初始函数
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        EventCenter.AddListener(EventType.startDragDrop, StaratDragDrop);
        EventCenter.AddListener(EventType.StartDragSize, StartDragSize);
    }

    /// <summary>
    /// 启用拖拽组件
    /// </summary>
    private void StaratDragDrop()
    {
        if (dragDrop!=null)
            dragDrop.enabled = true;
        if (dragUIToResize != null)
            dragUIToResize.enabled = false;
    }

    /// <summary>
    /// 启用拖拽缩放组件
    /// </summary>
    private void StartDragSize()
    {
        if (dragDrop != null)
            dragDrop.enabled = false;
        if (dragUIToResize != null)
            dragUIToResize.enabled = true;
    }

    /// <summary>
    /// 销毁函数
    /// </summary>
    protected override void OnDestroy()
    {
        base.OnDestroy();
        EventCenter.RemoveListener(EventType.startDragDrop, StaratDragDrop);
        EventCenter.RemoveListener(EventType.StartDragSize, StartDragSize);
    }
    #endregion
}
