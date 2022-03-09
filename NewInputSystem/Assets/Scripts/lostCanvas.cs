using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lostCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("input");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
