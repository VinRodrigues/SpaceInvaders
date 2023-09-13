using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.0f;
    private float waitTime = 1.0f;
    private int state = 0;
    private float x;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        x = transform.position.x;



    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;
        }
        var pos = transform.position;
        if (state >= -5 && state < 0)
        {
            pos.x = x - state;
        }
        else if (state == 0)
        {
            pos.y -= 0.5f;
            ChangeState();
            pos.x = x;
        }
        else if (state > 0 && state <= 5)
        {
            pos.x = x + state;
        }
        transform.position = pos;


    }

    void ChangeState()
    {
        state = state + 1;
        if (state > 5)
        {
            state = -5;
        }
    }

}
