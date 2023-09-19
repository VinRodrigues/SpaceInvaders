using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOscript : MonoBehaviour
{
    public float entrySpeed = 2.0f; 
    public float exitSpeed = 10.0f; 
    public float exitXPosition = 20.0f; 

    void Start()
    {
        
        Vector3 initialPosition = new Vector3(Random.Range(-10.0f, -20.0f), Random.Range(-5.0f, 5.0f), 0.0f);
        transform.position = initialPosition;
    }

    void Update()
    {
        
        transform.Translate(Vector3.right * entrySpeed * Time.deltaTime);

       
        if (transform.position.x <= 0.0f)
        {
            
            transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
        }

        
        if (transform.position.x >= exitXPosition)
        {
            
            Destroy(gameObject);
        }
    }
}
