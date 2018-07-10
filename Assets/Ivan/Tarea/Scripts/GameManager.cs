using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState
{
    Start = 0,
    Playing = 1,
    End = 2,
}

public class GameManager : MonoBehaviour 
{
    public GameState current;

    void Start()
    {
        SetGameState(GameState.Playing);
    }

    public void StartGame()
    {
        SetGameState(GameState.Start);
    }
    public void GameOver()
    {
        SetGameState(GameState.End)
    }
    public void BackToMenu()
    {
        SetGameState(GameState.Start);
    }

    void SetGameState(GameState newGameState)
    {
        
    }
	// Update is called once per frame
	void Update () 
    {
		
	}
}
