using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public GameObject BluePortal;
    public GameObject OrangePortal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OrangePortal"))
        {
            transform.position = (BluePortal.transform.position);
        }
    }
}
