using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 程序主入口
/// </summary>
public class Main
{
    /// <summary>
    /// 程序运行主函数
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
   public static void MainEnter()
    {
        DataManager.Instance.Init();
        PathManager.Instance.Init();
        UIManager.Instance.Init();
    }
}
