using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandCursorMovement : MonoBehaviour
{
    [SerializeField] private float targetHandPos;
    [SerializeField] private float handMovementDuration;
    private void Start()
    {
        MoveTheHand();
    }

    private void MoveTheHand()
    {
        transform.DOMoveY(targetHandPos, handMovementDuration).SetLoops(-1, LoopType.Restart).SetLink(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
        }
    }
}
