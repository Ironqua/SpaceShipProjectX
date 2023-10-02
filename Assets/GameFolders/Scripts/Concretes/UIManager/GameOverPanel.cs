using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    //gameoverpanel button script
    public void RestartGame()
    {
        SceneManager.LoadScene(1);

    }

    public void ExitGame()
    {
        GameManager.Instance.Exit();
    }
}
