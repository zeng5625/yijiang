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
    /// ʵʩ���������ֵ�
    /// </summary>
    private Dictionary<string, implementItemDataBase> impCondfigDir;
    public Dictionary<string, implementItemDataBase> ImpCondfigDir
    {
        set 
        {
            impCondfigDir = value; 
        }
        get 
        { 
            return impCondfigDir; 
        } 
    }
    #endregion

    #region ʵʩ�����������ݺ���

    #endregion
}
