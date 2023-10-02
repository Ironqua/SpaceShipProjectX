using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public event Action OnGameOver;
    public event Action OnMissionSucced;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {

        Singleton();
    }

    private void Singleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }



    public void MissionSucced()
    {
        OnMissionSucced.Invoke();
    }

    public void GameOver()
    {
       OnGameOver.Invoke();

    }

    public void LoadLevelScene(int levelIndex=0)
    {
        StartCoroutine(LoadLevelSceneAsync(levelIndex));
    }

    private IEnumerator LoadLevelSceneAsync(int levelIndex)
    {
        yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex);   
    }
    public void LoadMenuScene()
    {
        StartCoroutine(LoadLevelSceneAsync());
    }

    private IEnumerator LoadLevelSceneAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");

    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("exit");

    }

}


