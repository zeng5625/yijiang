using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݹ�����
/// </summary>
public class DataManager : SingleLetonManager<DataManager>
{
    #region ���ݹ������ֶ�
    /// <summary>
    /// ʵʩ������������
    /// </summary>
    private ImplementationConfigData impConfigData;
    public ImplementationConfigData ImpConfigData
    {
        set
        {
            impConfigData = value;
        }
        get 
        { 
            return impConfigData;
        }
    }
    #endregion

    #region ���ݹ���������
    /// <summary>
    /// ��ʼ������
    /// </summary>
    public void Init()
    {
        impConfigData=new ImplementationConfigData();

    }
    #endregion
}
