using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float topbound = 25;
    private float bottombound = -10;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (transform.position.z > topbound )
        {
            Destroy(gameObject);
        }
       else if (transform.position.z < bottombound)
        {
            Destroy(gameObject);
        }
    }
}
