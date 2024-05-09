using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

/// <summary>
/// ����Item��
/// </summary>
public class ArchitectureItem : ArchitectureConfigItem
{
    #region ����Item���ֶ�
    [HideLabel]
    [LabelText("����Trans��Ϣ")]
    public RectTransform rectTrans;

    [HideLabel]
    [LabelText("��ק���")]
    public DragDrop dragDrop;

    [HideLabel]
    [LabelText("��ק�������")]
    public PointerDragDragUIToResize dragUIToResize;
    #endregion

    #region ����Item�ຯ��
    /// <summary>
    /// ��ʼ����
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        EventCenter.AddListener(EventType.startDragDrop, StaratDragDrop);
        EventCenter.AddListener(EventType.StartDragSize, StartDragSize);
    }

    /// <summary>
    /// ������ק���
    /// </summary>
    private void StaratDragDrop()
    {
        if (dragDrop!=null)
            dragDrop.enabled = true;
        if (dragUIToResize != null)
            dragUIToResize.enabled = false;
    }

    /// <summary>
    /// ������ק�������
    /// </summary>
    private void StartDragSize()
    {
        if (dragDrop != null)
            dragDrop.enabled = false;
        if (dragUIToResize != null)
            dragUIToResize.enabled = true;
    }

    /// <summary>
    /// ���ٺ���
    /// </summary>
    protected override void OnDestroy()
    {
        base.OnDestroy();
        EventCenter.RemoveListener(EventType.startDragDrop, StaratDragDrop);
        EventCenter.RemoveListener(EventType.StartDragSize, StartDragSize);
    }
    #endregion
}
