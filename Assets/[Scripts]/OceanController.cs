using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{

    public float verticalSpeed;
    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed);
    }

    void Move()
    {
        
    }

    void CheckBounds()
    {
        if (transform.position.y <= boundary.bottom)
        {
            ResetObject();
        }
    }

    void ResetObject()
    {
        transform.position = new Vector2(0.0f, boundary.top);
    }
}
