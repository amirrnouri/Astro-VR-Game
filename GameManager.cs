using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    private void Awake()
    {
        _gameState.Score = 0;
        _gameState.GameOver = false;
        _gameState.GameSpeed=1;

    }

    private void Update()
    {
        Time.timeScale = _gameState.GameSpeed;
        if (_gameState.GameOver)
        GAMEOVER();



        if (SceneManager.GetSceneByName("MainMenu").isLoaded)
        {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));

        }

         if (SceneManager.GetSceneByName("MainScene").isLoaded)
        {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainScene"));

        }

    }



    
    public void GAMEOVER()
    {
        _gameState.LoadScene("MainMenu");
        SceneManager.UnloadSceneAsync("MainScene");

    }
    




}