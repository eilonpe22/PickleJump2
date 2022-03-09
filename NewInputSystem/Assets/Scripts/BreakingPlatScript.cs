using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatScript : MonoBehaviour
{
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
