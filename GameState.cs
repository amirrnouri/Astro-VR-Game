using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;



[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/CreateGameDataAsset")]
public class GameState : ScriptableObject
{
    public float Score;
    public UnityEvent<int> OnIncreaseScore;
    public UnityEvent OnGameOver;
    public float GameSpeed = 1;
    [SerializeField] private bool _gameOver;

    public float gameOverDelay=0.5f;


void Awake()
    {
      GameSpeed = 1;
        
    }


    void Update()
    {
      
    }




    public bool GameOver
    {
        get => _gameOver;
        set
        {
            _gameOver = value;

            if (_gameOver)
                OnGameOver?.Invoke();
        }
    }
    public void IncreaseScore(float amount)
    {
        Score += amount;

        //OnIncreaseScore?.Invoke(Score);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
