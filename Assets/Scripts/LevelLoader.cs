using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    private void Start()
    {
        LoadRequiredLevel();
    }


    private void LoadRequiredLevel()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            StartCoroutine(LoadSavedLevelRoutine());
        }
        else
        {
            StartCoroutine(LoadNextLevelRoutine());
        }
    }

    private IEnumerator LoadSavedLevelRoutine()
    {
        int savedLevel = PlayerPrefs.GetInt("SavedLevel");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(savedLevel);
    }

    private IEnumerator LoadNextLevelRoutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
