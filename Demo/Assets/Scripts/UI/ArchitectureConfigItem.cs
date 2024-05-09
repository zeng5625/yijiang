using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 建筑配置Item类
/// </summary>
public class ArchitectureConfigItem : UIBase
{
    #region 建筑配置Item类字段
    [HideLabel]
    [LabelText("建筑名称")]
    public string ArchitectureName;

    [HideLabel]
    [LabelText("建筑编号")]
    public int ArchitectureIndex;

    [HideLabel]
    [LabelText("建筑图标")]
    public Image architectureIcon;
    #endregion

    #region 建筑配置Item类函数

    #endregion
}
