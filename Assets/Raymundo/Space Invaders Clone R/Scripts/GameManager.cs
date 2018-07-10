namespace Raymundo
{
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
        public Transform enemy;

        public GameState current;

        // Use this for initialization
        void Start()
        {
            SetGameState(GameState.Start);
        }

        public void StartGame()
        {
            SetGameState(GameState.Playing);
        }

        public void GameOver()
        {
            SetGameState(GameState.End);
        }

        public void BackToMenu()
        {
            SetGameState(GameState.Start);
        }

        void SetGameState(GameState newGameState)
        {
            if (newGameState == GameState.Start)
            {
                Debug.Log("Start Game");
            }

            else if (newGameState == GameState.Playing)
            {
                Debug.Log("Playing Game");
            }

            else if (newGameState == GameState.End)
            {
                Debug.Log("Game Over");
            }

            this.current = newGameState;
        }




        // Update is called once per frame
        void Update()
        {

        }
    }
 
}
