using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;
using static UnityEditor.Progress;

/// <summary>
/// ʵʩ���ݱ༭���
/// </summary>
public class EditorImpUIPanel : UIBase
{
    #region ʵʩ���ݱ༭����ֶ�
    #region �����༭�ֶ�
    [HideLabel]
    [LabelText("�����������ݱ���·����ť")]
    public Button ArchitectureDataSavePathButton;

    [HideLabel]
    [LabelText("�����������ݱ���·���ı�")]
    public TextMeshProUGUI ArchitectureDataSavePathText;

    [HideLabel]
    [LabelText("�������水ť")]
    public Button ArchitectureSaveButton;

    [HideLabel]
    [LabelText("������ԭ��ť")]
    public Button ArchitectureRestoreButton;

    [HideLabel]
    [LabelText("���������ť")]
    public Button ArchitectureClearButton;

    [HideLabel]
    [LabelText("�������˰�ť")]
    public Button ArchitectureRollbackButton;

    [HideLabel]
    [LabelText("����Trans�ĸ�������")]
    public RectTransform ArchitectureTransParent;
    #endregion

    #region ʵʩ�����ֶ�
    [HideLabel]
    [LabelText("ʵʩ�����������ݱ���·����ť")]
    public Button ImpelentDataSavePathButton;

    [HideLabel]
    [LabelText("ʵʩ�����������ݱ���·���ı�")]
    public TextMeshProUGUI ImpelentDataSavePathText;

    [HideLabel]
    [LabelText("�������水ť")]
    public Button ImpelentSaveButton;

    [HideLabel]
    [LabelText("������ԭ��ť")]
    public Button ImpelentRestoreButton;

    [HideLabel]
    [LabelText("���������ť")]
    public Button ImpelentClearButton;

    [HideLabel]
    [LabelText("�������˰�ť")]
    public Button ImpelentRollbackButton;

    [HideLabel]
    [LabelText("����Trans�ĸ�������")]
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
    /// �������ݻ�ԭ����¼�
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
    /// ���������������¼�
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
    /// �������ݻ��˵���¼�
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
    /// ʵʩ�������ݻ�ԭ����¼�
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
    /// ʵʩ���������������¼�
    /// </summary>
    private void OnImpelentClearButtonClick()
    {
        DataManager.Instance.ImpConfigData.ClearAllImpConfigList();

    }

    /// <summary>
    /// ʵʩ�������ݻ��˵���¼�
    /// </summary>
    private void OnImpelentRollbackButtonClick()
    {
        DataManager.Instance.ImpConfigData.RemoveLastImpConfigListData();

    }
    #endregion
    #endregion
}
