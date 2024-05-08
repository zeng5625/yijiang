using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// ������ק��
/// </summary>
public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    /// <summary>
    /// ����Ļ�����Ϣ���
    /// </summary>
    private RectTransform rectTrans;

    /// <summary>
    /// ����Ļ������
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
    /// ��ק���̺���
    /// </summary>
    /// <param name="eventData">�����Ϣ</param>
    public void OnDrag(PointerEventData eventData)

    {

        rectTrans.anchoredPosition += eventData.delta;

        //��ȡ���UIͼƬ�����Anchorê���λ��������Ϣ

        //eventData.delta�Դ���һ��Update���û���������������ƶ���2Dλ��������Ϣ      

    }

    /// <summary>
    /// ��ק��ʼ����
    /// </summary>
    /// <param name="eventData">�����Ϣ</param>
    public void OnBeginDrag(PointerEventData eventData)

    {

        canvasGroup.blocksRaycasts = false;

        canvasGroup.alpha = 0.5f;

    }

    /// <summary>
    /// ��ק��������
    /// </summary>
    /// <param name="eventData">�����Ϣ</param>
    public void OnEndDrag(PointerEventData eventData)

    {

        canvasGroup.blocksRaycasts = true;

        canvasGroup.alpha = 1f;

    }
}