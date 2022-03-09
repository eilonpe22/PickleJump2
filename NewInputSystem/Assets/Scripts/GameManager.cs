using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 spawnPosition;
    public Vector3 coinsPos;
    public GameObject platformPrefab;
    public GameObject coinsPrefab;
    public GameObject lastPlat;
    public GameObject enemyPrefab;
    public GameObject _breakinPlatformPrefab;
    public Transform _playerTransform;
    public PlayerMovemant playerScore;
    public GameObject[] _platforms;
    public GameObject[] _enemys;

    // Start is called before the first frame update
    void Start()
    {
      
        for(int i= 0; i <= 5; i++)
        {
           // SpawenPlatform();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(_playerTransform.position.y > spawnPosition.y - 15)
        {
            SpawenPlatform();
            SpawenBreakingPlatform();
            MovingPlatform();
            Enemy();
            //coins();
        }
        
       
        if(_playerTransform == null)
        {
            Debug.Log("Player is dead");
        }
        
    }
    void SpawenPlatform()
    {
        if (  _playerTransform.position.y < 100f)
        {
            //lastPlat = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            float randX = Random.Range(-3f, 3f);
            float randY = Random.Range(2f, 4);
            spawnPosition.x = randX;
            spawnPosition.y += randY;
            lastPlat = Instantiate(_platforms[0], spawnPosition, Quaternion.identity);

            spawnPosition.y += 2f;
            // lastPlat.transform.position = coinsPrefab.transform.position;

            Instantiate(coinsPrefab, spawnPosition, Quaternion.identity);

        }
    }
    void SpawenBreakingPlatform()
    {
        if ( _playerTransform.position.y > 100f && _playerTransform.position.y < 200f)
        {
            float randX = Random.Range(-3f, 3f);
            float randY = Random.Range(2f, 4);
            spawnPosition.x = randX;
            spawnPosition.y += randY;
            Instantiate(_breakinPlatformPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void MovingPlatform()
    {
        if ( _playerTransform.position.y >150f)
        {
            //coinsPos = new Vector3(_platforms[1].transform.position.x, _platforms[1].transform.position.y + 5f, _platforms[1].transform.position.z);
            float randX = Random.Range(-3f, 3f);
            float randY = Random.Range(2f, 4);
            spawnPosition.x = randX;
            spawnPosition.y += randY;
            int randPlat = Random.Range(0, _platforms.Length);
            lastPlat = Instantiate(_platforms[randPlat], spawnPosition, Quaternion.identity);
            
            spawnPosition.y += 2f;
            // lastPlat.transform.position = coinsPrefab.transform.position;

            Instantiate(coinsPrefab, spawnPosition, Quaternion.identity);

        }
    }
    void Enemy()
    {
        if (_playerTransform.position.y > 200f)
        {
            
            float randX = Random.Range(-3f, 3f);
            float randY = Random.Range(0f,12f);
            spawnPosition.x = randX;
            spawnPosition.y += randY;
            int randEnemy = Random.Range(0, _enemys.Length);
            Instantiate(enemyPrefab, spawnPosition, transform.rotation);
        }
    }
 
    void coins()
    {
        if (_playerTransform.position.y > 10f)
        {
            //coinsPos = new Vector3(_platforms[1].transform.position.x, _platforms[1].transform.position.y + 5f, _platforms[1].transform.position.z);
            coinsPos = new Vector3(platformPrefab.transform.position.x, platformPrefab.transform.position.y + 2f, platformPrefab.transform.position.z);
            float randX = Random.Range(-3f, 3f);
            float randY = Random.Range(2f, 4);
            spawnPosition.x = randX;
            spawnPosition.y += randY;

            Instantiate(coinsPrefab, spawnPosition,Quaternion.identity);

            //  Instantiate(coinsPrefab,coinsPos, Quaternion.identity);

        }
    }
}
