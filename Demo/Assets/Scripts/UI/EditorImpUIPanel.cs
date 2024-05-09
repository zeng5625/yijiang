using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;

/// <summary>
/// 实施内容编辑面板
/// </summary>
public class EditorImpUIPanel : UIBase
{
    #region 实施内容编辑面板字段
    #region 实施内容编辑左部字段
    [HideLabel]
    [LabelText("建筑视图箭头按钮")]
    public Button ArchitectureViewArrowButton;

    [HideLabel]
    [LabelText("建筑视图箭头图标")]
    public Image ArchitectureArrowIcon;

    [HideLabel]
    [LabelText("建筑视图组件")]
    public ScrollRect ArchitectureRect;

    [HideLabel]
    [LabelText("图标视图箭头按钮")]
    public Button IconViewArrowButton;

    [HideLabel]
    [LabelText("图标箭头图标")]
    public Image IconArrowIcon;

    [HideLabel]
    [LabelText("图标视图组件")]
    public ScrollRect IconRect;

    [HideLabel]
    [LabelText("实施内容试图箭头按钮")]
    public Button ImpViewArrowButton;

    [HideLabel]
    [LabelText("实施内容箭头图标")]
    public Image ImpArrowIcon;

    [HideLabel]
    [LabelText("实施内容视图组件")]
    public ScrollRect ImpRect;

    [HideLabel]
    [LabelText("向右箭头")]
    public Sprite rightArrow;

    [HideLabel]
    [LabelText("向下箭头")]
    public Sprite downArrow;

    /// <summary>
    /// 建筑箭头是否点击
    /// </summary>
    private bool Architectureclick;

    /// <summary>
    /// 图标箭头是否点击
    /// </summary>
    private bool Iconclick;

    /// <summary>
    /// 实施箭头是否点击
    /// </summary>
    private bool Impclick;  
    #endregion

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

    [HideLabel]
    [LabelText("建筑显示部分的Item")]
    public ArchitectureItem architectureItem;
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
        if(ArchitectureViewArrowButton!=null)
        {
            ArchitectureViewArrowButton.onClick.AddListener(OnArchitectureViewArrowButtonClick);
        }
        if (IconViewArrowButton != null)
        {
            IconViewArrowButton.onClick.AddListener(OnIconViewArrowButtonClick);
        }
        if (ImpViewArrowButton != null)
        {
            ImpViewArrowButton.onClick.AddListener(OnImpViewArrowButtonClick);
        }
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
    #region 实施内容左部函数
    /// <summary>
    /// 建筑视图箭头点击事件
    /// </summary>
    public void OnArchitectureViewArrowButtonClick()
    {
        Architectureclick = !Architectureclick;
        if (Architectureclick) 
        {
            ArchitectureArrowIcon.sprite=downArrow;
            ArchitectureRect.gameObject.SetActive(true);
            ArchitectureViewArrowButton.transform.localRotation = Quaternion.identity;
        }
        else
        {
            ArchitectureArrowIcon.sprite=rightArrow;
            ArchitectureRect.gameObject.SetActive(false);
            ArchitectureViewArrowButton.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
    }

    /// <summary>
    /// 图标视图箭头点击事件
    /// </summary>
    public void OnIconViewArrowButtonClick()
    {
        Iconclick = !Iconclick;
        if (Iconclick)
        {
            IconArrowIcon.sprite = downArrow;
            IconRect.gameObject.SetActive(true);
            IconViewArrowButton.transform.localRotation = Quaternion.identity;
        }
        else
        {
            IconArrowIcon.sprite = rightArrow;
            IconRect.gameObject.SetActive(false);
            IconViewArrowButton.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
    }

    /// <summary>
    /// 实施内容视图箭头点击事件
    /// </summary>
    public void OnImpViewArrowButtonClick()
    {
        Impclick = !Impclick;
        if (Impclick)
        {
            ImpArrowIcon.sprite = downArrow;
            ImpRect.gameObject.SetActive(true);
            ImpViewArrowButton.transform.localRotation = Quaternion.identity;
        }
        else
        {
            ImpArrowIcon.sprite = rightArrow;
            ImpRect.gameObject.SetActive(false);
            ImpViewArrowButton.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
    }
    #endregion
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
            List<architectureItemData> list= DataManager.Instance.ReadFile<List<architectureItemData>>(ArchitectureDataSavePathText.text + PathManager.Instance.Architecturename);
            if (list != null&& list.Count>0)
            {
                for (int i = 0;i<list.Count;++i)
                {
                    architectureItemData data = list[i];
                    if (data != null&&ArchitectureTransParent&& architectureItem) 
                    {
                        ArchitectureItem item=Instantiate(architectureItem,ArchitectureTransParent);
                        if (item)
                        {
                            item.ArchitectureName = data.ArchitectureName;
                            item.ArchitectureIndex = data.ArchitectureIndex;
                            item.rectTrans.localPosition = new Vector2(data.TransPosX,data.TransPosY);
                            item.rectTrans.sizeDelta = new Vector2(data.TransScaleWith,data.TransScaleHight);
                            item.architectureIcon.sprite=Tools.Instance.LoadSpriteByPath(PathManager.Instance.ArchitectureIconFolderPath+data.ArchitectureIcon);
                            item.gameObject.SetActive(true);
                        }
                    }
                }
            }
            DataManager.Instance.ImpConfigData.ArchitectureCondfigList = list;
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
