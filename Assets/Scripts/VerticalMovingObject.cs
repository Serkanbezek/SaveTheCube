using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VerticalMovingObject : MonoBehaviour
{
    [SerializeField] private float targetYPos;
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
        transform.DOMoveY(targetYPos, movementDuration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void KillTween()
    {
        DOTween.Kill(transform);
    }
}
