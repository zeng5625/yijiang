using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// ������
/// </summary>
public class Tools:SingleLetonManager<Tools>
{
    #region �������ֶ�

    #endregion

    #region �����ຯ��

    /// <summary>
    /// ����Ԥ����
    /// </summary>
    /// <param name="path">����·��</param>
    /// <param name="Parent">��������</param>
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
    /// ���ݾ���·������ͼƬ
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

