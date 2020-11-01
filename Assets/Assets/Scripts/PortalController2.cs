using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController2 : MonoBehaviour
{

    public int score2;
    private Vector2 origPos;

    private void Start()
    {
        origPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            collision.gameObject.SetActive(false);
            score2++;
        }
    }
}
