using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;
using static UnityEditor.Progress;

/// <summary>
/// 实施内容编辑面板
/// </summary>
public class EditorImpUIPanel : UIBase
{
    #region 实施内容编辑面板字段
    #region 建筑编辑字段
    [HideLabel]
    [LabelText("建筑配置数据保存路径按钮")]
    public Button ArchitectureDataSavePathButton;

    [HideLabel]
    [LabelText("建筑配置数据保存路径文本")]
    public TextMeshProUGUI ArchitectureDataSavePathText;

    [HideLabel]
    [LabelText("建筑保存按钮")]
    public Button ArchitectureSaveButton;

    [HideLabel]
    [LabelText("建筑还原按钮")]
    public Button ArchitectureRestoreButton;

    [HideLabel]
    [LabelText("建筑清除按钮")]
    public Button ArchitectureClearButton;

    [HideLabel]
    [LabelText("建筑回退按钮")]
    public Button ArchitectureRollbackButton;

    [HideLabel]
    [LabelText("建筑Trans的父级物体")]
    public RectTransform ArchitectureTransParent;
    #endregion

    #region 实施内容字段
    [HideLabel]
    [LabelText("实施内容配置数据保存路径按钮")]
    public Button ImpelentDataSavePathButton;

    [HideLabel]
    [LabelText("实施内容配置数据保存路径文本")]
    public TextMeshProUGUI ImpelentDataSavePathText;

    [HideLabel]
    [LabelText("建筑保存按钮")]
    public Button ImpelentSaveButton;

    [HideLabel]
    [LabelText("建筑还原按钮")]
    public Button ImpelentRestoreButton;

    [HideLabel]
    [LabelText("建筑清除按钮")]
    public Button ImpelentClearButton;

    [HideLabel]
    [LabelText("建筑回退按钮")]
    public Button ImpelentRollbackButton;

    [HideLabel]
    [LabelText("建筑Trans的父级物体")]
    public RectTransform ImppletentTransParent;
    #endregion

    #endregion

    protected override void Awake()
    {
        base.Awake();
        if (ArchitectureDataSavePathButton != null ) 
        {
            ArchitectureDataSavePathButton.onClick.AddListener(OnArchitectureDataSavePathButtonClick);
        }
        if (ArchitectureSaveButton != null) 
        {
            ArchitectureSaveButton.onClick.AddListener(OnArchitectureSaveButtonClick);
        }
        if (ArchitectureRestoreButton != null)
        {
            ArchitectureRestoreButton.onClick.AddListener(OnArchitectureRestoreButtonClick);
        }
        if (ArchitectureClearButton != null)
        {
            ArchitectureClearButton.onClick.AddListener(OnArchitectureClearButtonClick);
        }
        if (ArchitectureRollbackButton != null)
        {
            ArchitectureRollbackButton.onClick.AddListener(OnArchitectureRollbackButtonClick);
        }
        if (ImpelentDataSavePathButton != null)
        {
            ImpelentDataSavePathButton.onClick.AddListener(OnImpelentDataSavePathButtonClick);
        }
        if (ImpelentSaveButton != null)
        {
            ImpelentSaveButton.onClick.AddListener(OnImpelentSaveButtonClick);
        }
        if (ImpelentRestoreButton != null)
        {
            ImpelentRestoreButton.onClick.AddListener(OnImpelentRestoreButtonClick);
        }
        if (ImpelentClearButton != null)
        {
            ImpelentClearButton.onClick.AddListener(OnImpelentClearButtonClick);
        }
        if (ImpelentRollbackButton != null)
        {
            ImpelentRollbackButton.onClick.AddListener(OnImpelentRollbackButtonClick);
        }
    }

    #region 实施内容编辑面板函数
    #region 建筑编辑函数
    /// <summary>
    /// 建筑数据保存路径点击事件
    /// </summary>
    private void OnArchitectureDataSavePathButtonClick()
    {
        OpenFile.OpenWinFile(ArchitectureDataSavePathText);
    }

    /// <summary>
    /// 建筑数据保存点击事件
    /// </summary>
    private void OnArchitectureSaveButtonClick()
    {
        ArchitectureItem[] architectures = ArchitectureTransParent.GetComponentsInChildren<ArchitectureItem>();
        if(architectures!=null&&architectures.Length>0)
        {
            for (int i = 0; i < architectures.Length; i++)
            {
                architectureItemData data=new architectureItemData();
                data.ArchitectureName = architectures[i].ArchitectureName;
                data.ArchitectureIcon = architectures[i].architectureIcon.name;
                data.ArchitectureIndex = architectures[i].ArchitectureIndex;
                data.TransPosX = architectures[i].rectTrans.anchoredPosition.x;
                data.TransPosY= architectures[i].rectTrans.anchoredPosition.y;
                data.TransScaleWith = architectures[i].rectTrans.sizeDelta.x;
                data.TransScaleHight = architectures[i].rectTrans.sizeDelta.y;
                DataManager.Instance.ImpConfigData.AddarchitectureCondfigListData(data);
            }
        }
        if (!string.IsNullOrEmpty(ArchitectureDataSavePathText.text))
        {
            DataManager.Instance.WriteFile(ArchitectureDataSavePathText.text + PathManager.Instance.Architecturename, DataManager.Instance.ImpConfigData);
        }
    }

    /// <summary>
    /// 建筑数据还原点击事件
    /// </summary>
    private void OnArchitectureRestoreButtonClick()
    {
        if (!string.IsNullOrEmpty(ArchitectureDataSavePathText.text) && DataManager.Instance.ImpConfigData != null)
        {
            DataManager.Instance.ImpConfigData.ArchitectureCondfigList = DataManager.Instance.ReadFile<List<architectureItemData>>(ArchitectureDataSavePathText.text + PathManager.Instance.Architecturename);
            if (DataManager.Instance.ImpConfigData.ArchitectureCondfigList != null)
            {

            }
        }
    }

    /// <summary>
    /// 建筑数据清除点击事件
    /// </summary>
    private void OnArchitectureClearButtonClick()
    {
        DataManager.Instance.ImpConfigData.ClearAllarchitectureCondfigList();
        if(ArchitectureTransParent)
        {
            ArchitectureItem[] items=ArchitectureTransParent.GetComponentsInChildren<ArchitectureItem>();
            if(items!=null&&items.Length>0)
            {
                foreach(ArchitectureItem item in items) 
                {
                    DestroyImmediate(item.gameObject);
                }
            }
        }
    }

    /// <summary>
    /// 建筑数据回退点击事件
    /// </summary>
    private void OnArchitectureRollbackButtonClick()
    {
        DataManager.Instance.ImpConfigData.RemoveLastarchitectureCondfigListData();
        ArchitectureItem[] items = ArchitectureTransParent.GetComponentsInChildren<ArchitectureItem>();
        if (items != null && items.Length > 0)
        {
            DestroyImmediate(items[items.Length-1].gameObject);
        }
    }
    #endregion

    #region 实施编辑函数
    /// <summary>
    /// 实施内容数据保存路径点击事件
    /// </summary>
    private void OnImpelentDataSavePathButtonClick()
    {
        OpenFile.OpenWinFile(ImpelentDataSavePathText);
    }

    /// <summary>
    /// 实施内容数据保存点击事件
    /// </summary>
    private void OnImpelentSaveButtonClick()
    {
        if(!string.IsNullOrEmpty(ImpelentDataSavePathText.text))
        {
            ArchitectureItem[] architectures = ArchitectureTransParent.GetComponentsInChildren<ArchitectureItem>();
            if (architectures != null && architectures.Length > 0)
            {
                for (int i = 0; i < architectures.Length; i++)
                {
                    implementItemData data = new implementItemData();
                    data.ImpName = architectures[i].ArchitectureName;
                    data.ImpIndex = architectures[i].ArchitectureIndex;
                    DataManager.Instance.ImpConfigData.AddImpCondfigListData(data);
                }
            }
            DataManager.Instance.WriteFile(ImpelentDataSavePathText.text+PathManager.Instance.Impname,DataManager.Instance.ImpConfigData);
        }
    }

    /// <summary>
    /// 实施内容数据还原点击事件
    /// </summary>
    private void OnImpelentRestoreButtonClick()
    {
        if (!string.IsNullOrEmpty(ImpelentDataSavePathText.text)&& DataManager.Instance.ImpConfigData!=null)
        {
            DataManager.Instance.ImpConfigData.ImpConfigList = DataManager.Instance.ReadFile<List<implementItemData>>(ImpelentDataSavePathText.text + PathManager.Instance.Impname);
            if(DataManager.Instance.ImpConfigData.ImpConfigList != null)
            {

            }
        }
    }

    /// <summary>
    /// 实施内容数据清除点击事件
    /// </summary>
    private void OnImpelentClearButtonClick()
    {
        DataManager.Instance.ImpConfigData.ClearAllImpConfigList();

    }

    /// <summary>
    /// 实施内容数据回退点击事件
    /// </summary>
    private void OnImpelentRollbackButtonClick()
    {
        DataManager.Instance.ImpConfigData.RemoveLastImpConfigListData();

    }
    #endregion
    #endregion
}
