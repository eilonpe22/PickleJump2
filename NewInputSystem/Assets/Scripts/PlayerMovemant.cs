using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemant : MonoBehaviour
{
    Rigidbody rb;
    public float _movePower = 15;
    public int _score;
    public int _playerLife = 4;
    public int _coinsCollected;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemant();
    }
   public void Movemant()
    {
        float horizontalMovement = Input.GetAxis("Horizontal")  * _movePower;
        Vector3 newMovement = rb.velocity;
        newMovement.x = horizontalMovement;
        rb.velocity = newMovement;
        int checkScore =Mathf.RoundToInt( transform.position.y * 5);
        if (checkScore > _score)
        {
            _score = checkScore;
        }
    }
}
