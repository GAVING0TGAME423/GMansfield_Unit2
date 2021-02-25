using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10;
    private float xbound = 20;
    void Start()
    {
        
    }

   
    void Update()
    {
      HorizontalInput =  Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed );

        if(transform.position.x > xbound)
        {
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xbound)
        {
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
        }
    }
}
