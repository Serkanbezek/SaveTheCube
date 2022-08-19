using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingObjects : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Collider2D ObjectCollider;
    public bool Enabled;
    private float currentTime = 0;
    [SerializeField] private float timeToToggleObject = 2;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        ObjectCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (GameManager.Instance.IsGameActive)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= timeToToggleObject)
            {
                currentTime = 0;
                ToggleObject();
            }
        }
    }
    private void ToggleObject()
    {
        Enabled = !Enabled;
        ObjectCollider.enabled = Enabled;
        SpriteRenderer.enabled = Enabled;
    }
}
