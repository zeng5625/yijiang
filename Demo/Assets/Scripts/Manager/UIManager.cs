using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

/// <summary>
/// UI管理器
/// </summary>
public class UIManager : SingleLetonManager<UIManager>
{
    #region UI管理器字段
    /// <summary>
    /// UI面板字典
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
    /// ui根节点
    /// </summary>
    private UIRoot uiroot;
    public UIRoot uIRoot
    { 
        set { uiroot = value; }
        get { return uiroot; } 
    }
    #endregion

    #region UI管理器函数
    /// <summary>
    /// 初始化函数
    /// </summary>
    public void Init()
    {
        UIdir = new Dictionary<string, Dictionary<string, UIBase>>();
        uiroot = Tools.Instance.LoadGameObjectByPath(PathManager.Instance.Prefabepath+PathManager.Instance.Uirootpath+PathManager.Instance.PrefabeSuffixpath).GetComponent<UIRoot>();
    }

    /// <summary>
    /// 给UI面板字典添加UI面板
    /// </summary>
    /// <param name="sceneName">场景名称</param>
    /// <param name="UIPanelName">UI面板名称</param>
    /// <param name="ui">UI面板</param>
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
    /// 获取UI面板
    /// </summary>
    /// <param name="sceneName">场景名称</param>
    /// <param name="UIPanelName">UI面板名称</param>
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
    /// 清楚所有函数
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
