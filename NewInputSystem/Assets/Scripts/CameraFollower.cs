using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform _playerTransform;
    private float _offset;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position.y - _playerTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(_playerTransform != null)
        {

        
            float newYPos = _playerTransform.position.y + _offset;
            if (newYPos > transform.position.y)
                transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);
        }
    }
}
