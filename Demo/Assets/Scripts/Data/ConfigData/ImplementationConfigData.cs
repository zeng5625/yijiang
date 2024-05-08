using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 实施内容配置数据
/// </summary>
public class ImplementationConfigData : DataBase
{
    #region 实施内容配置数据字段
    /// <summary>
    /// 实施内容配置字典
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

    #region 实施内容配置数据函数

    #endregion
}
