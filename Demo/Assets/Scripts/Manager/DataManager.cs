using System.Collections;
using System.Collections.Generic;
using System.IO;
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

    /// <summary>
    /// д���ļ�
    /// </summary>
    /// <param name="path">�ļ�·��</param>
    /// <param name="data">�ļ�����</param>
    public void WriteFile(string path,DataBase data)
    {
        string content = JsonUtility.ToJson(data);
        if (!string.IsNullOrEmpty(path)&&!string.IsNullOrEmpty(content))
            File.WriteAllText(path,content);
    }

    /// <summary>
    /// ��ȡ�ļ�
    /// </summary>
    /// <param name="path">�ļ�·��</param>
    public T ReadFile<T>(string path) 
    {
        T t = default;
        if (string.IsNullOrEmpty(path))
         t=JsonUtility.FromJson<T>(path);
        return t;
    }
    #endregion
}
