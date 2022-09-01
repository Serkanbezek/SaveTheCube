using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CircularMovingObject : MonoBehaviour
{
    [SerializeField] private Transform rotationCenter;
    [SerializeField] private float rotationSpeed;
    /*[SerializeField] private float rotationRadius, angularSpeed;
    private float posX, posY, angle = 0;

    private void Update()
    {
        posX = rotationCenter.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle += 15 * Mathf.Rad2Deg * Time.deltaTime * angularSpeed;
        Debug.Log(angle);
    
    */
    private void Update()
    {
        if (GameManager.Instance.IsGameActive)
        {
            transform.RotateAround(rotationCenter.position, new Vector3(0, 0, 1), Time.deltaTime * rotationSpeed);
        }
    }
}
