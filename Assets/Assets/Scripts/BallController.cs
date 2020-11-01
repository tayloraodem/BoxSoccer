using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public int redScoreCount = 0;
    public int blueScoreCount = 0;
    private Vector2 origPos;
    private Rigidbody2D rb2d;

    public Text blueScore;
    public Text redScore;

    private void Start()
    {
        origPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Portal1"))
        {
            transform.position = origPos;
            redScoreCount++;
            redScore.text = ""+redScoreCount; 
            if (rb2d != null)
            {
                rb2d.velocity = Vector2.zero;
                rb2d.angularVelocity = 0;
            }

            
        }

        if (collision.gameObject.CompareTag("Portal2"))
        {
            transform.position = origPos;
            blueScoreCount++;
            blueScore.text = "" + blueScoreCount;
            if (rb2d != null)
            {
                rb2d.velocity = Vector2.zero;
                rb2d.angularVelocity = 0;
            }
        }
    }
}
