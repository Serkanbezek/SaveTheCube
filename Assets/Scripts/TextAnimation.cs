using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 scaleRate;
    [SerializeField] private float scaleDuration;

    private void Start()
    {
        AnimateText();
    }

    private void AnimateText()
    {
        transform.DOScale(scaleRate, scaleDuration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
        }
    }
}
