using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLastPlayedLevel : MonoBehaviour
{
    private int levelToLoad;
    private void Start()
    {
        if (PlayerPrefs.HasKey("LastPlayedLevel"))
        {
            levelToLoad = PlayerPrefs.GetInt("LastPlayedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
