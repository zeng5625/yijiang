using System.Collections;
using System.Collections.Generic;
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
    #endregion
}
