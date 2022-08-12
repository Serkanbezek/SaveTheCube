using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalMovingObject : MonoBehaviour
{
    [SerializeField] private float targetXPos;
    [SerializeField] private float movementDuration;
    private void OnEnable()
    {
        PlayerEvents.PlayerKill += KillTween;
        PlayerEvents.LevelEnded += KillTween;
    }

    private void OnDisable()
    {
        PlayerEvents.PlayerKill -= KillTween;
        PlayerEvents.LevelEnded -= KillTween;
    }
    private void Start()
    {
        MoveTheObject();
    }

    private void MoveTheObject()
    {
        transform.DOMoveX(targetXPos, movementDuration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void KillTween()
    {
        DOTween.Kill(transform);
    }
}
