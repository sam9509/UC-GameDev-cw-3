using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemetnt : MonoBehaviour
{

    private Rigidbody2D RB;
    public float speed;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {

        RB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);


    }
}
