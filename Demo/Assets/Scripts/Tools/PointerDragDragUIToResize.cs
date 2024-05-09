using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// ��ק�ƶ�UI�Ĵ�С
/// ��Ӵing˵��
/// 1����� UI
/// 2����קUI��UI�Ĵ�С�ͻ���ı仯
/// 3���仯�����޶���С�ڱ仯
/// </summary>
public class PointerDragDragUIToResize : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    [Header("��������Сֵ")]
    public Vector2 minSize = new Vector2(50, 50);
    [Header("���������ֵ")]
    public Vector2 maxSize = new Vector2(500, 500);

    [Header("����������ж���ֵ")]
    public float mouseDistance = 0.5f;

    // UI �� RectTransform
    private RectTransform panelRectTransform;

    // ��갴�µ�ʱ�����λ��ת��UI��λ�õĴ�С
    private Vector2 originalLocalPointerPosition;

    // ��갴�µ�ʱ��UIԭ���Ĵ�С
    private Vector2 originalSizeDelta;

    // �ж����ĵ��λ�ã������ϻ�������(�ñ仯�����������drag�Ǳ�С������drag�Ǳ��)
    private bool isUpLeft = false;

    void Start()
    {
        panelRectTransform = transform.GetComponent<RectTransform>();

    }

    /// <summary>
    /// ��갴���¼�
    /// </summary>
    /// <param name="data"></param>
    public void OnPointerDown(PointerEventData data)
    {
        // ��¼�������仯ǰ�Ĵ�С
        originalSizeDelta = panelRectTransform.sizeDelta;

        // ��¼��������λ��
        RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position, data.pressEventCamera, out originalLocalPointerPosition);
        float distance=Vector2.Distance(Vector2.zero , originalLocalPointerPosition);
        if (distance < mouseDistance) 
        {
            EventCenter.Broadcast(EventType.startDragDrop);
        }
        else
        {
            // �ж����ĵ��λ��(�Խ��߷�)
            if ((originalLocalPointerPosition.x - originalLocalPointerPosition.y) < 0)
            {
                isUpLeft = true;

            }
            else
            {
                isUpLeft = false;

            }
        }
    }

    /// <summary>
    /// ��ק�¼�
    /// </summary>
    /// <param name="data"></param>
    public void OnDrag(PointerEventData data)
    {
        // UI �İ�ȫУ��
        if (panelRectTransform == null)
            return;

        // Drag �仯�ı���
        Vector2 localPointerPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position, data.pressEventCamera, out localPointerPosition);

        // Drag �仯ֵ����갴����קǰ��ֵ֮��Ĳ�ֵ
        Vector3 offsetToOriginal = localPointerPosition - originalLocalPointerPosition;

        // UI RectTransform ��ֵ�仯 ��ע�����Ϻ����µ�����Դ���
        Vector2 sizeDelta = originalSizeDelta + new Vector2(offsetToOriginal.x, -offsetToOriginal.y) * (isUpLeft == true ? -1 : 1);
        sizeDelta = new Vector2(
                Mathf.Clamp(sizeDelta.x, minSize.x, maxSize.x),
                Mathf.Clamp(sizeDelta.y, minSize.y, maxSize.y)
        );

        // ��ֵ��ʵ�ִ�С����
        panelRectTransform.sizeDelta = sizeDelta;
    }


}
