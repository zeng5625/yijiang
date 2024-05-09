using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 实施Item数据基类
/// </summary>
public class implementItemData
{
    #region 实施Item数据基类字段
    /// <summary>
    /// 实施Item名称
    /// </summary>
    private string impName;
    public string ImpName
    {
        set
        {
            impName = value;
        }
        get
        {
            return impName;
        }
    }

    /// <summary>
    /// 实施编号
    /// </summary>
    private int impIndex;
    public int ImpIndex
    {
        set
        {
            impIndex = value;
        }
        get
        {
            return impIndex;
        }
    }
    #endregion

    #region 实施Item数据基类函数

    #endregion
}
