using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10f;
    [SerializeField]
    string axisName;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw(axisName) * speed;
        rb.velocity = new Vector2(0, y);
    }
}
