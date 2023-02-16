using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;
    public Boundary boundary;
    public Boundary speeds;

    // Start is called before the first frame update
    void Start()
    {
        ResetObject();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(horizontalSpeed, verticalSpeed);
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
        float randomXPosition = Random.Range(boundary.left, boundary.right);
        float randomYPosition = Random.Range(boundary.top, boundary.top + 3);
        verticalSpeed = Random.Range(speeds.top, speeds.bottom);
        horizontalSpeed = Random.Range(speeds.left, speeds.right);
        transform.position = new Vector2(randomXPosition, boundary.top);
    }
}
