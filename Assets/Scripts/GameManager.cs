using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public bool IsGameActive = true;

    private void Start()
    {
        Application.targetFrameRate = -1;
    }
    private void OnEnable()
    {
        PlayerEvents.PlayerKill += DeactivateGame;
        PlayerEvents.LevelEnded += DeactivateGame;
    }

    private void OnDisable()
    {
        PlayerEvents.PlayerKill -= DeactivateGame;
        PlayerEvents.LevelEnded += DeactivateGame;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DeactivateGame()
    {
        IsGameActive = false;
    }

    public void ActivateGame()
    {
        IsGameActive = true;
    }
}
