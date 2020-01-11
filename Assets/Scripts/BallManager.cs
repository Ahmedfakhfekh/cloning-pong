using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    public Text ScoreRight, ScoreLeft;
    Rigidbody2D rb;
    float speed = 20f;
    int scoreRight, scoreLeft;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if(col.gameObject.name == "BorderRight")
        {
            scoreLeft++;
            ScoreLeft.text = scoreLeft.ToString();
        }
        if (col.gameObject.name == "BorderLeft")
        {
            scoreRight++;
            ScoreRight.text = scoreRight.ToString();
        }
    }
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        scoreLeft = 0;
        scoreRight = 0;
    }
}
