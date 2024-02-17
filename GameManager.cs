using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

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
    }
}