using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����Item����
/// </summary>
public class architectureItemData
{
    #region ����Item�����ֶ�
    /// <summary>
    /// ��������
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
    /// �������
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
    /// ����ͼ��
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
    /// Transform��Ϣλ�õ�Xֵ
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
    /// Transform��Ϣλ�õ�Yֵ
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
    /// Transform��Ϣ���ŵĳ���ֵ
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
    /// Transform��Ϣ���ŵĸ߶�ֵ
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

    #region ����Item���ݺ���

    #endregion
}
