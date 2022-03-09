using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    bool _leftRight;
    [Range(3, 20)]
    public float _jForce;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_leftRight)
        {
            transform.position = new Vector3(transform.position.x + 0.009f, transform.position.y, transform.position.z);
            if (transform.position.x > 3f)
                _leftRight = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.009f, transform.position.y, transform.position.z);
            if (transform.position.x < -3f)
                _leftRight = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovemant>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = _jForce;
                rb.velocity = newVelocity;
                Destroy(this.gameObject);
            }


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovemant>() && rb.velocity.y < 0)
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Destroy(this.gameObject);
        }

    }
}
