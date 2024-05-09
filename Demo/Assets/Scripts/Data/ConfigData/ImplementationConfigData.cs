using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 实施内容配置数据
/// </summary>
public class ImplementationConfigData : DataBase
{
    #region 实施内容配置数据字段
    /// <summary>
    /// 建筑配置字典
    /// </summary>
    private List<architectureItemData> architectureCondfigList;
    public List<architectureItemData> ArchitectureCondfigList
    {
        set
        {
            architectureCondfigList = value;
        }
        get
        {
            return architectureCondfigList;
        }
    }

    /// <summary>
    /// 建筑名称的最后指向
    /// </summary>
    private string architectureLastName;

    public string ArchitectureLastName
    {
        set
        {
            architectureLastName = value;
        }
        get
        {
            return architectureLastName;
        }
    }
    /// <summary>
    /// 实施内容配置字典
    /// </summary>
    private List<implementItemData> impConfigList;
    public List<implementItemData> ImpConfigList
    {
        set 
        {
            impConfigList = value; 
        }
        get 
        { 
            return impConfigList; 
        } 
    }

    /// <summary>
    /// 实施内容名称的最后指向
    /// </summary>
    private string impLastName;
    public string ImpLastName
    {
        set 
        {
            impLastName = value;
        }
        get 
        {
            return impLastName;
        }
    }
    #endregion

    #region 实施内容配置数据函数
    /// <summary>
    /// 构造函数
    /// </summary>
    public ImplementationConfigData() 
    {
        architectureCondfigList = new List<architectureItemData>();
        impConfigList = new List<implementItemData>();
    }

    #region 建筑配置函数
    /// <summary>
    /// 给建筑字典添加数据
    /// </summary>
    /// <param name="data">实施内容数据</param>
    public void AddarchitectureCondfigListData(architectureItemData data)
    {
        if (architectureCondfigList != null)
        {
            architectureCondfigList.Add(data);
        }
    }

    /// <summary>
    /// 获取建筑内容Item数据
    /// </summary>
    /// <param name="architecturename">建筑名称</param>
    /// <param name="architecturename">建筑编号</param>
    /// <returns></returns>
    public architectureItemData GetarchitectureCondfigDirData(string architecturename,int index)
    {
        architectureItemData data = null;
        if (architectureCondfigList != null&& architectureCondfigList.Count>0)
        {
            List<architectureItemData> currentList= new List<architectureItemData>();
            for (int i = 0; i < architectureCondfigList.Count; ++i) 
            {
                if (architectureCondfigList[i].ArchitectureName.Equals(architecturename))
                    currentList.Add(data);
            }
            if(currentList.Count>0)
            data = currentList[index];
        }
        return data;
    }

    /// <summary>
    /// 移除最后一个建筑数据
    /// </summary>
    public void RemoveLastarchitectureCondfigListData()
    {
        if (architectureCondfigList != null && architectureCondfigList.Count > 1)
            architectureCondfigList.RemoveAt(architectureCondfigList.Count-1);
    }

    /// <summary>
    /// 清除所有建筑数据字典
    /// </summary>
    public void ClearAllarchitectureCondfigList()
    {
        if (architectureCondfigList != null)
            architectureCondfigList.Clear();
    }


    #endregion

    #region 实施内容配置函数
    /// <summary>
    /// 给实施内容字典添加数据
    /// </summary>
    /// <param name="data">实施内容数据</param>
    public void AddImpCondfigListData(implementItemData data) 
    {
        if(impConfigList != null)
        {
            impConfigList.Add(data);
        }
    }

    /// <summary>
    /// 获取实施内容Item数据
    /// </summary>
    /// <param name="impname">实施内容名称</param>
    /// <param name="index">实施内容编号</param>
    /// <returns></returns>
    public implementItemData GetImpConfigListData(string impname,int index) 
    {
        implementItemData data = null;
        if(impConfigList !=null&& impConfigList.Count>0)
        {
            List<implementItemData> currentList = new List<implementItemData>();
            for (int i = 0; i < impConfigList.Count; ++i)
            {
                if (impConfigList[i].ImpName.Equals(impname))
                    currentList.Add(data);
            }
            if (currentList.Count > 0)
                data = currentList[index];
        }
        return data;
    }

    /// <summary>
    /// 移除最后一个实施内容数据
    /// </summary>
    public void RemoveLastImpConfigListData()
    {
        if (impConfigList != null && impConfigList.Count > 1)
            impConfigList.RemoveAt(impConfigList.Count - 1);
    }

    /// <summary>
    /// 清除所有实施内容数据字典
    /// </summary>
    public void ClearAllImpConfigList()
    {
        if(impConfigList != null)
            impConfigList.Clear();
    }
    #endregion
    /// <summary>
    /// 清除所有数据
    /// </summary>
    public void ClearAllData()
    {
        ClearAllarchitectureCondfigList();
        architectureCondfigList = null;
        ClearAllImpConfigList();
        impConfigList = null;
    }
    #endregion
}
