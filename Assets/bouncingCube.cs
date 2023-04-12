using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingCube : MonoBehaviour
{
    public Rigidbody rbCube;
    public Vector3 force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Debug.Log("Touch bouncing plane");
            rbCube.AddForce(force);
        }
    }
}
