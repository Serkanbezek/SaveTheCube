using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button TryAgainButton;
    public Button NextLevelButton;

    private void OnEnable()
    {
        PlayerEvents.PlayerKill += TryAgainButtonActive;
        PlayerEvents.LevelEnded += NextLevelButtonActive;
    }
    private void OnDisable()
    {
        PlayerEvents.PlayerKill -= TryAgainButtonActive;
        PlayerEvents.LevelEnded -= NextLevelButtonActive;
    }

    private void TryAgainButtonActive() => TryAgainButton.gameObject.SetActive(true);

    private void NextLevelButtonActive() => NextLevelButton.gameObject.SetActive(true);
}
