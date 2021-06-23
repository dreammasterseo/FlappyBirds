using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Berd _berd;
    [SerializeField] private PupeGeneration _pupeGeneration;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EndScreen _endScreen;

    private void OnEnable()
    {
        _startScreen.PlayButtonClick += OnStartButtonClick;
        _endScreen.RestartButtonClick += OnRestartButtonClick;
        _berd.GameOwer += OnGameOver;
    }

    private void OnDisable()
    {
        _startScreen.PlayButtonClick -= OnStartButtonClick;
        _endScreen.RestartButtonClick -= OnRestartButtonClick;
        _berd.GameOwer -= OnGameOver;
    }

    private void Start()
    {
        Time.timeScale = 0;
        _startScreen.Open();
    }

    private void OnStartButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }

    private void OnRestartButtonClick()
    {
        _endScreen.Close();
        _pupeGeneration.ResetPool();
        StartGame();
    }

    private void StartGame()
    {
        _berd.ResetOlayer();
        Time.timeScale = 1;
        
    }

    public void OnGameOver()
    {
        Time.timeScale = 0;
        _endScreen.Open();
    }
}
