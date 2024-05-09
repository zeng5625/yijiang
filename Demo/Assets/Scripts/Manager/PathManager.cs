using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ·��������
/// </summary>
public class PathManager : SingleLetonManager<PathManager>
{
    #region ·���������ֶ�
    /// <summary>
    /// Ԥ�������·��
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
    /// Ԥ�����׺·��
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
    /// Ԥ�������·��
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

    /// <summary>
    /// �����ļ�����
    /// </summary>
    private string architecturename = "architecture.txt";
    public string Architecturename
    {
        set 
        {
            architecturename = value;
        }
        get
        {
            return architecturename;
        }
    }

    /// <summary>
    /// ʵʩ�����ļ�����
    /// </summary>
    private string impname = "imp.txt";
    public string Impname
    {
        set
        {
            Impname = value;
        }
        get
        {
            return Impname;
        }
    }
    #endregion

    #region ·������������
    /// <summary>
    /// ��ʼ������
    /// </summary>
    public void Init()
    {

    }
    #endregion
}
