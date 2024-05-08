using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 路径管理器
/// </summary>
public class PathManager : SingleLetonManager<PathManager>
{
    #region 路径管理器字段
    /// <summary>
    /// 预制体相对路径
    /// </summary>
    private string prefabepath= "Assets/Prefabes/";
    public string Prefabepath
    {
        set
        {
            prefabepath = value;
        }
        get
        {
            return prefabepath;
        }
    }

    /// <summary>
    /// 预制体后缀路径
    /// </summary>
    private string prefabeSuffixpath = ".prefab";
    public string PrefabeSuffixpath
    {
        set
        {
            prefabeSuffixpath = value;
        }
        get
        {
            return prefabeSuffixpath;
        }
    }

    /// <summary>
    /// 预制体相对路径
    /// </summary>
    private string uirootpath = "UIRoot";
    public string Uirootpath
    {
        set
        {
            uirootpath = value;
        }
        get
        {
            return uirootpath;
        }
    }
    #endregion

    #region 路径管理器函数
    /// <summary>
    /// 初始化函数
    /// </summary>
    public void Init()
    {

    }
    #endregion
}
