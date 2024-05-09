using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 建筑Item数据
/// </summary>
public class architectureItemData
{
    #region 建筑Item数据字段
    /// <summary>
    /// 建筑名称
    /// </summary>
    private string architectureName;
    public string ArchitectureName
    {
        set
        {
            architectureName = value;
        }
        get 
        {
            return architectureName;
        }
    }

    /// <summary>
    /// 建筑编号
    /// </summary>
    private int architectureindex;
    public int ArchitectureIndex
    {
        set
        {
            architectureindex = value;
        }
        get
        {
            return architectureindex;
        }
    }

    /// <summary>
    /// 建筑图标
    /// </summary>
    private string architectureIcon;
    public string ArchitectureIcon
    {
        set
        {
            architectureIcon = value;
        }
        get
        {
            return architectureIcon;
        }
    }

    /// <summary>
    /// Transform信息位置的X值
    /// </summary>
    private float transPosX;
    public float TransPosX
    {
        set
        {
            transPosX = value;
        }
        get
        {
            return transPosX;
        }
    }

    /// <summary>
    /// Transform信息位置的Y值
    /// </summary>
    private float transPosY;
    public float TransPosY
    {
        set
        {
            transPosY = value;
        }
        get
        {
            return transPosY;
        }
    }

    /// <summary>
    /// Transform信息缩放的长度值
    /// </summary>
    private float transScaleWith;
    public float TransScaleWith
    {
        set
        {
            transScaleWith = value;
        }
        get
        {
            return transScaleWith;
        }
    }

    /// <summary>
    /// Transform信息缩放的高度值
    /// </summary>
    private float transScaleHight;
    public float TransScaleHight
    {
        set
        {
            transScaleHight = value;
        }
        get
        {
            return transScaleHight;
        }
    }
    #endregion

    #region 建筑Item数据函数

    #endregion
}
