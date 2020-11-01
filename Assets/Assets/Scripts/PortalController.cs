using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PortalController : MonoBehaviour {

    public int score;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            collision.gameObject.SetActive(false);
            score++;
        }
    }
}
