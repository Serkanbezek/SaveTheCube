using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEvents : MonoBehaviour
{
    public static event Action PlayerKill, LevelEnded;

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
            gameObject.SetActive(false);
        }
    }
}