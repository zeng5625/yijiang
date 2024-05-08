using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 实施内容编辑面板
/// </summary>
public class EditorImpUIPanel : UIBase
{
    #region 实施内容编辑面板字段
    #region 建筑编辑字段
    /// <summary>
    /// 建筑配置数据保存路径按钮
    /// </summary>
    public Button ArchitectureDataSavePathButton;

    /// <summary>
    /// 建筑配置数据保存路径文本
    /// </summary>
    public TextMeshProUGUI ArchitectureDataSavePathText;

    /// <summary>
    /// 建筑保存按钮
    /// </summary>
    public Button ArchitectureSaveButton;

    /// <summary>
    /// 建筑还原按钮
    /// </summary>
    public Button ArchitectureRestoreButton;

    /// <summary>
    /// 建筑清除按钮
    /// </summary>
    public Button ArchitectureClearButton;

    /// <summary>
    /// 建筑回退按钮
    /// </summary>
    public Button ArchitectureRollbackButton;
    #endregion

    #region 实施内容字段
    /// <summary>
    /// 实施内容配置数据保存路径按钮
    /// </summary>
    public Button ImpelentDataSavePathButton;

    /// <summary>
    /// 实施内容配置数据保存路径文本
    /// </summary>
    public TextMeshProUGUI ImpelentDataSavePathText;

    /// <summary>
    /// 建筑保存按钮
    /// </summary>
    public Button ImpelentSaveButton;

    /// <summary>
    /// 建筑还原按钮
    /// </summary>
    public Button ImpelentRestoreButton;

    /// <summary>
    /// 建筑清除按钮
    /// </summary>
    public Button ImpelentClearButton;

    /// <summary>
    /// 建筑回退按钮
    /// </summary>
    public Button ImpelentRollbackButton;
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
        
    }

    /// <summary>
    /// 建筑数据还原点击事件
    /// </summary>
    private void OnArchitectureRestoreButtonClick()
    {

    }

    /// <summary>
    /// 建筑数据清除点击事件
    /// </summary>
    private void OnArchitectureClearButtonClick()
    {

    }

    /// <summary>
    /// 建筑数据回退点击事件
    /// </summary>
    private void OnArchitectureRollbackButtonClick()
    {

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

    }

    /// <summary>
    /// 实施内容数据还原点击事件
    /// </summary>
    private void OnImpelentRestoreButtonClick()
    {

    }

    /// <summary>
    /// 实施内容数据清除点击事件
    /// </summary>
    private void OnImpelentClearButtonClick()
    {

    }

    /// <summary>
    /// 实施内容数据回退点击事件
    /// </summary>
    private void OnImpelentRollbackButtonClick()
    {

    }
    #endregion
    #endregion
}
