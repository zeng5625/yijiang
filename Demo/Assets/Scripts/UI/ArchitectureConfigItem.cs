using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��������Item��
/// </summary>
public class ArchitectureConfigItem : UIBase
{
    #region ��������Item���ֶ�
    [HideLabel]
    [LabelText("��������")]
    public string ArchitectureName;

    [HideLabel]
    [LabelText("�������")]
    public int ArchitectureIndex;

    [HideLabel]
    [LabelText("����ͼ��")]
    public Image architectureIcon;
    #endregion

    #region ��������Item�ຯ��

    #endregion
}
