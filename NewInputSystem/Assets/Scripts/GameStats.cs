using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public Text _lifeText;
    public Text _scoreText;
    public Text _coinsText;
    public PlayerMovemant _playerMovemant;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = _playerMovemant._score.ToString();
        _lifeText.text = _playerMovemant._playerLife.ToString();
        _coinsText.text = _playerMovemant._coinsCollected.ToString();
    }
}
