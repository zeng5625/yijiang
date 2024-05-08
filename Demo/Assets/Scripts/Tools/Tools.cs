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
    #endregion
}

