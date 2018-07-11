namespace Ivan
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
        public GameState current;

        public Transform enemy;
        public Transform player;
        public Transform baseHolder;
        public Canvas mainMenu;
        
        


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
        public void Quit()
        {
            Application.Quit();
        }


        void SetGameState(GameState newGameState)
        {
            if (newGameState == GameState.Start)
            {
                mainMenu.enabled = true;
                
                baseHolder.gameObject.SetActive(false);
                enemy.gameObject.SetActive(false);
                player.gameObject.SetActive(false);

            }

            else if (newGameState == GameState.Playing)
            {
                mainMenu.enabled = false;
                
                baseHolder.gameObject.SetActive(true);
                enemy.gameObject.SetActive(true);
                player.gameObject.SetActive(true);


            }

            else if (newGameState == GameState.End)
            {
                
                mainMenu.enabled = false;
                
                baseHolder.gameObject.SetActive(false);
                enemy.gameObject.SetActive(false);
                player.gameObject.SetActive(false);


            }

            this.current = newGameState;
        }
    }
       
      
    
}

