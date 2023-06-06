using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerEvents : MonoBehaviour
{
    public static event Action PlayerKill, LevelEnded;

    private int _maxLevel = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            PlayerKill?.Invoke();
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("LevelEndGate"))
        {
            LevelEnded?.Invoke();
            SaveLevelData();
            gameObject.SetActive(false);
        }
    }



    private void SaveLevelData()
    {
        if (SceneManager.GetActiveScene().buildIndex == _maxLevel)
        {
            PlayerPrefs.SetInt("SavedLevel", SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            PlayerPrefs.SetInt("SavedLevel", SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}