using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

/// <summary>
/// UI������
/// </summary>
public class UIManager : SingleLetonManager<UIManager>
{
    #region UI�������ֶ�
    /// <summary>
    /// UI����ֵ�
    /// </summary>
    private Dictionary<string, Dictionary<string, UIBase>> UIdir;
    public Dictionary<string, Dictionary<string, UIBase>> UIDir
    {
        set
        {
            UIdir = value;
        }
        get
        {
            return UIdir;
        }
    }

    /// <summary>
    /// ui���ڵ�
    /// </summary>
    private UIRoot uiroot;
    public UIRoot uIRoot
    { 
        set { uiroot = value; }
        get { return uiroot; } 
    }
    #endregion

    #region UI����������
    /// <summary>
    /// ��ʼ������
    /// </summary>
    public void Init()
    {
        UIdir = new Dictionary<string, Dictionary<string, UIBase>>();
        uiroot = Tools.Instance.LoadGameObjectByPath(PathManager.Instance.Prefabepath+PathManager.Instance.Uirootpath+PathManager.Instance.PrefabeSuffixpath).GetComponent<UIRoot>();
    }

    /// <summary>
    /// ��UI����ֵ����UI���
    /// </summary>
    /// <param name="sceneName">��������</param>
    /// <param name="UIPanelName">UI�������</param>
    /// <param name="ui">UI���</param>
    public void AddUIPanel(string sceneName,string UIPanelName,UIBase ui)
    {
        if(UIdir!=null)
        {
            if(UIdir.ContainsKey(sceneName))
            {
                if (UIdir[sceneName].ContainsKey(UIPanelName))
                {
                    UIdir[sceneName][UIPanelName] = ui;
                }
                else
                {
                    UIdir[sceneName].Add(UIPanelName, ui);
                }
            }
            else
            {
                Dictionary<string,UIBase> dir= new Dictionary<string,UIBase>();
                dir.Add(UIPanelName, ui);
                UIdir.Add(sceneName, dir);
            }
        }
    }

    /// <summary>
    /// ��ȡUI���
    /// </summary>
    /// <param name="sceneName">��������</param>
    /// <param name="UIPanelName">UI�������</param>
    /// <returns></returns>
    public UIBase GetUIPanel(string sceneName,string UIPanelName)
    {
        UIBase ui = null;
        if(UIdir!=null) 
        {
            if (UIdir.ContainsKey(sceneName))
            {
                if (UIdir[sceneName].ContainsKey(UIPanelName))
                {
                    ui = UIdir[sceneName][UIPanelName];
                }
            }
        }
        return ui;
    }

    /// <summary>
    /// ������к���
    /// </summary>
    public void AllClear()
    {
        if(UIdir!=null)
        {
            UIdir.Clear();
            UIdir = null;
        }
    }
    #endregion
}
