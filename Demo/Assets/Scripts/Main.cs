using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������
/// </summary>
public class Main
{
    /// <summary>
    /// ��������������
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
   public static void MainEnter()
    {
        DataManager.Instance.Init();
        PathManager.Instance.Init();
        UIManager.Instance.Init();
    }
}
