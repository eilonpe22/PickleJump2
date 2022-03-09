using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [Range(3, 20)]
    public float _jForce;
    Rigidbody rb;
    public GameObject lostcanvas;
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
            Destroy(this.gameObject);
            other.GetComponent<PlayerMovemant>()._playerLife--;
            Rigidbody rb = other.GetComponent<Rigidbody>();
           if (rb.velocity.y <1) 
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = _jForce;
                rb.velocity = newVelocity;
               Destroy(this.gameObject);
            }
            if(other.GetComponent<PlayerMovemant>()._playerLife < 1)
            {
                Destroy(other.gameObject);
                lostcanvas.SetActive(true);
            }



        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovemant>() && rb.velocity.y < 0)
        {
            
            Rigidbody rb = other.GetComponent<Rigidbody>();
           
        }

    }
}
