using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// 数据管理器
/// </summary>
public class DataManager : SingleLetonManager<DataManager>
{
    #region 数据管理器字段
    /// <summary>
    /// 实施内容配置数据
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

    #region 数据管理器函数
    /// <summary>
    /// 初始化函数
    /// </summary>
    public void Init()
    {
        impConfigData=new ImplementationConfigData();
        
    }

    /// <summary>
    /// 写入文件
    /// </summary>
    /// <param name="path">文件路径</param>
    /// <param name="data">文件数据</param>
    public void WriteFile(string path,DataBase data)
    {
        string content = JsonUtility.ToJson(data);
        if (!string.IsNullOrEmpty(path)&&!string.IsNullOrEmpty(content))
            File.WriteAllText(path,content);
    }

    /// <summary>
    /// 读取文件
    /// </summary>
    /// <param name="path">文件路径</param>
    public T ReadFile<T>(string path) 
    {
        T t = default;
        if (string.IsNullOrEmpty(path))
         t=JsonUtility.FromJson<T>(path);
        return t;
    }
    #endregion
}
