using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    Begin = 0,
    Playing = 1,
    End = 2,
}

public class GameManager : MonoBehaviour
{
    // SINGLETON
    public static GameManager instance;

    public Transform enemy;
    public Transform player;
    public Canvas mainMenu;
    public Canvas endMenu;

    public EnemyManager enemyManager;

    private GameState current;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetGameState(GameState.Begin);
    }

    public void StartGame()
    {
        SetGameState(GameState.Playing);
    }

    public void GameOver()
    {
        SetGameState(GameState.End);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SetGameState(GameState.Begin);
    }

    void SetGameState(GameState newGameState)
    {

        if (newGameState == GameState.Begin)
        {
            Debug.Log("Game Start");
            mainMenu.enabled = true;
            endMenu.enabled = false;
            enemy.gameObject.SetActive(false);
            player.gameObject.SetActive(false);

        }  

        else if (newGameState == GameState.Playing)
        {
            Debug.Log("Playing");
            mainMenu.enabled = false;
            endMenu.enabled = false;
            enemy.gameObject.SetActive(true);
            player.gameObject.SetActive(true);

        }

        else if (newGameState == GameState.End)
        {
            Debug.Log("Game Over");
            mainMenu.enabled = false;
            endMenu.enabled = true;
            enemy.gameObject.SetActive(false);
            player.gameObject.SetActive(false);

        }

        this.current = newGameState;
    }

}
