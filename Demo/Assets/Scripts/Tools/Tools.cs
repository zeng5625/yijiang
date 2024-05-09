using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 工具类
/// </summary>
public class Tools:SingleLetonManager<Tools>
{
    #region 工具类字段

    #endregion

    #region 工具类函数

    /// <summary>
    /// 加载预制体
    /// </summary>
    /// <param name="path">绝对路径</param>
    /// <param name="Parent">父级物体</param>
    /// <returns></returns>
    public GameObject LoadGameObjectByPath(string path,Transform Parent=null)
    {
        GameObject obj = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (obj != null)
        {
            obj = Object.Instantiate(obj);
            if (Parent != null) 
            {
                obj.transform.parent = Parent;
            }
        }
        return obj;
    }

    /// <summary>
    /// 根据绝对路径加载图片
    /// </summary>
    /// <param name="iconName"></param>
    /// <returns></returns>
    public Sprite LoadSpriteByPath(string iconpath)
    {
        Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(iconpath);
        return sprite;
    }
    #endregion
}

