using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/CreateGameDataAsset")]
public class GameState : ScriptableObject
{
    public int Score;
    public UnityEvent<int> OnIncreaseScore;
    public UnityEvent OnGameOver;
    public float GameSpeed = 1;
    [SerializeField] private bool _gameOver;



/*
    public float AstroBigMaxHeath=100;
    public float AstroBigDamagePower=100;
    public float AstroBigScore=100;
    

    public float AstroMedMaxHeath=50;
    public float AstroMedDamagePower=50;
    public float AstroMedScore=50;

    public float AstroLilMaxHeath=50;
    public float AstroLilDamagePower=50;
    public float AstroLilScore=50;    

    public float UFOMaxHeath=50;
    public float UFOScore=50;
    public float UFOBulletPower=10;

    public float PlayerBulletPower=50;
*/

void Start()
    {
        // Add variable data to the dictionary
        
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
    public void IncreaseScore(int amount)
    {
        Score += amount;

        OnIncreaseScore?.Invoke(Score);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
