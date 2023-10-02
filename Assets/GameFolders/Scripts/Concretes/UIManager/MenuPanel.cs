using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel:MonoBehaviour
{
   // menu buttons script
    public void Exit()
    {
        GameManager.Instance.Exit();
    }

    public void StartGame()
    {
        GameManager.Instance.LoadLevelScene(1);
    }

}
