using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [Range (3, 20)]
    public float _jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovemant>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if(rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = _jumpForce;
                rb.velocity = newVelocity;
            }
           
        }
    }
}
