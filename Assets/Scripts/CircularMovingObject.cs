using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CircularMovingObject : MonoBehaviour
{
    [SerializeField] private Transform rotationCenter;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        if (GameManager.Instance.IsGameActive)
        {
            transform.RotateAround(rotationCenter.position, new Vector3(0, 0, 1), Time.deltaTime * rotationSpeed);
        }
    }
}
