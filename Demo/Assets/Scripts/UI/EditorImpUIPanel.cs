using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// ʵʩ���ݱ༭���
/// </summary>
public class EditorImpUIPanel : UIBase
{
    #region ʵʩ���ݱ༭����ֶ�
    #region �����༭�ֶ�
    /// <summary>
    /// �����������ݱ���·����ť
    /// </summary>
    public Button ArchitectureDataSavePathButton;

    /// <summary>
    /// �����������ݱ���·���ı�
    /// </summary>
    public TextMeshProUGUI ArchitectureDataSavePathText;

    /// <summary>
    /// �������水ť
    /// </summary>
    public Button ArchitectureSaveButton;

    /// <summary>
    /// ������ԭ��ť
    /// </summary>
    public Button ArchitectureRestoreButton;

    /// <summary>
    /// ���������ť
    /// </summary>
    public Button ArchitectureClearButton;

    /// <summary>
    /// �������˰�ť
    /// </summary>
    public Button ArchitectureRollbackButton;
    #endregion

    #region ʵʩ�����ֶ�
    /// <summary>
    /// ʵʩ�����������ݱ���·����ť
    /// </summary>
    public Button ImpelentDataSavePathButton;

    /// <summary>
    /// ʵʩ�����������ݱ���·���ı�
    /// </summary>
    public TextMeshProUGUI ImpelentDataSavePathText;

    /// <summary>
    /// �������水ť
    /// </summary>
    public Button ImpelentSaveButton;

    /// <summary>
    /// ������ԭ��ť
    /// </summary>
    public Button ImpelentRestoreButton;

    /// <summary>
    /// ���������ť
    /// </summary>
    public Button ImpelentClearButton;

    /// <summary>
    /// �������˰�ť
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

    #region ʵʩ���ݱ༭��庯��
    #region �����༭����
    /// <summary>
    /// �������ݱ���·������¼�
    /// </summary>
    private void OnArchitectureDataSavePathButtonClick()
    {
        OpenFile.OpenWinFile(ArchitectureDataSavePathText);
    }

    /// <summary>
    /// �������ݱ������¼�
    /// </summary>
    private void OnArchitectureSaveButtonClick()
    {
        
    }

    /// <summary>
    /// �������ݻ�ԭ����¼�
    /// </summary>
    private void OnArchitectureRestoreButtonClick()
    {

    }

    /// <summary>
    /// ���������������¼�
    /// </summary>
    private void OnArchitectureClearButtonClick()
    {

    }

    /// <summary>
    /// �������ݻ��˵���¼�
    /// </summary>
    private void OnArchitectureRollbackButtonClick()
    {

    }
    #endregion

    #region ʵʩ�༭����
    /// <summary>
    /// ʵʩ�������ݱ���·������¼�
    /// </summary>
    private void OnImpelentDataSavePathButtonClick()
    {
        OpenFile.OpenWinFile(ImpelentDataSavePathText);
    }

    /// <summary>
    /// ʵʩ�������ݱ������¼�
    /// </summary>
    private void OnImpelentSaveButtonClick()
    {

    }

    /// <summary>
    /// ʵʩ�������ݻ�ԭ����¼�
    /// </summary>
    private void OnImpelentRestoreButtonClick()
    {

    }

    /// <summary>
    /// ʵʩ���������������¼�
    /// </summary>
    private void OnImpelentClearButtonClick()
    {

    }

    /// <summary>
    /// ʵʩ�������ݻ��˵���¼�
    /// </summary>
    private void OnImpelentRollbackButtonClick()
    {

    }
    #endregion
    #endregion
}
