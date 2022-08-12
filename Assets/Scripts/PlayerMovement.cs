using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private float vectorPowerLimit;
    private Camera cam;
    private Vector2 force;
    private Vector3 startPoint;
    private Vector3 endPoint;
    private TrajectoryLine tl;
    private Vector2 difference;
    private float vectorPower;
    private bool isLineEnded = false;
    private bool isMouseButtonUp = false;
    public Rigidbody2D Rb;
    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
    }
    private void Update()
    {
        GetStartPoint();

        if (Rb.velocity == new Vector2(0, 0))
        {
            HandleMovement();
        }
        else if (Rb.velocity != new Vector2(0, 0) && !isLineEnded)
        {
            tl.EndLine();
            isLineEnded = true;
        }
    }
    private void FixedUpdate()
    {
        if (isMouseButtonUp)
        {
            Rb.AddForce(force * power, ForceMode2D.Impulse);
            isMouseButtonUp = false;
        }
    }
    private void HandleMovement()
    {    
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);
            isLineEnded = false;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;
            difference = new Vector2(startPoint.x - endPoint.x, startPoint.y - endPoint.y);
            vectorPower = Mathf.Clamp(difference.magnitude, -vectorPowerLimit, vectorPowerLimit);
            force = difference.normalized * vectorPower;
            isMouseButtonUp = true;
            tl.EndLine();
            isLineEnded = true;
            //Rb.AddForce(force * power, ForceMode2D.Impulse);
        }
    }
    private void GetStartPoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
        }
    }
}
