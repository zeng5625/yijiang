using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ʵʩ������������
/// </summary>
public class ImplementationConfigData : DataBase
{
    #region ʵʩ�������������ֶ�
    /// <summary>
    /// ���������ֵ�
    /// </summary>
    private List<architectureItemData> architectureCondfigList;
    public List<architectureItemData> ArchitectureCondfigList
    {
        set
        {
            architectureCondfigList = value;
        }
        get
        {
            return architectureCondfigList;
        }
    }

    /// <summary>
    /// �������Ƶ����ָ��
    /// </summary>
    private string architectureLastName;

    public string ArchitectureLastName
    {
        set
        {
            architectureLastName = value;
        }
        get
        {
            return architectureLastName;
        }
    }
    /// <summary>
    /// ʵʩ���������ֵ�
    /// </summary>
    private List<implementItemData> impConfigList;
    public List<implementItemData> ImpConfigList
    {
        set 
        {
            impConfigList = value; 
        }
        get 
        { 
            return impConfigList; 
        } 
    }

    /// <summary>
    /// ʵʩ�������Ƶ����ָ��
    /// </summary>
    private string impLastName;
    public string ImpLastName
    {
        set 
        {
            impLastName = value;
        }
        get 
        {
            return impLastName;
        }
    }
    #endregion

    #region ʵʩ�����������ݺ���
    /// <summary>
    /// ���캯��
    /// </summary>
    public ImplementationConfigData() 
    {
        architectureCondfigList = new List<architectureItemData>();
        impConfigList = new List<implementItemData>();
    }

    #region �������ú���
    /// <summary>
    /// �������ֵ��������
    /// </summary>
    /// <param name="data">ʵʩ��������</param>
    public void AddarchitectureCondfigListData(architectureItemData data)
    {
        if (architectureCondfigList != null)
        {
            architectureCondfigList.Add(data);
        }
    }

    /// <summary>
    /// ��ȡ��������Item����
    /// </summary>
    /// <param name="architecturename">��������</param>
    /// <param name="architecturename">�������</param>
    /// <returns></returns>
    public architectureItemData GetarchitectureCondfigDirData(string architecturename,int index)
    {
        architectureItemData data = null;
        if (architectureCondfigList != null&& architectureCondfigList.Count>0)
        {
            List<architectureItemData> currentList= new List<architectureItemData>();
            for (int i = 0; i < architectureCondfigList.Count; ++i) 
            {
                if (architectureCondfigList[i].ArchitectureName.Equals(architecturename))
                    currentList.Add(data);
            }
            if(currentList.Count>0)
            data = currentList[index];
        }
        return data;
    }

    /// <summary>
    /// �Ƴ����һ����������
    /// </summary>
    public void RemoveLastarchitectureCondfigListData()
    {
        if (architectureCondfigList != null && architectureCondfigList.Count > 1)
            architectureCondfigList.RemoveAt(architectureCondfigList.Count-1);
    }

    /// <summary>
    /// ������н��������ֵ�
    /// </summary>
    public void ClearAllarchitectureCondfigList()
    {
        if (architectureCondfigList != null)
            architectureCondfigList.Clear();
    }


    #endregion

    #region ʵʩ�������ú���
    /// <summary>
    /// ��ʵʩ�����ֵ��������
    /// </summary>
    /// <param name="data">ʵʩ��������</param>
    public void AddImpCondfigListData(implementItemData data) 
    {
        if(impConfigList != null)
        {
            impConfigList.Add(data);
        }
    }

    /// <summary>
    /// ��ȡʵʩ����Item����
    /// </summary>
    /// <param name="impname">ʵʩ��������</param>
    /// <param name="index">ʵʩ���ݱ��</param>
    /// <returns></returns>
    public implementItemData GetImpConfigListData(string impname,int index) 
    {
        implementItemData data = null;
        if(impConfigList !=null&& impConfigList.Count>0)
        {
            List<implementItemData> currentList = new List<implementItemData>();
            for (int i = 0; i < impConfigList.Count; ++i)
            {
                if (impConfigList[i].ImpName.Equals(impname))
                    currentList.Add(data);
            }
            if (currentList.Count > 0)
                data = currentList[index];
        }
        return data;
    }

    /// <summary>
    /// �Ƴ����һ��ʵʩ��������
    /// </summary>
    public void RemoveLastImpConfigListData()
    {
        if (impConfigList != null && impConfigList.Count > 1)
            impConfigList.RemoveAt(impConfigList.Count - 1);
    }

    /// <summary>
    /// �������ʵʩ���������ֵ�
    /// </summary>
    public void ClearAllImpConfigList()
    {
        if(impConfigList != null)
            impConfigList.Clear();
    }
    #endregion
    /// <summary>
    /// �����������
    /// </summary>
    public void ClearAllData()
    {
        ClearAllarchitectureCondfigList();
        architectureCondfigList = null;
        ClearAllImpConfigList();
        impConfigList = null;
    }
    #endregion
}
