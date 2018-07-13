using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour 
{
    public void OnResetButton()
    {
        GameManager.instance.StartGame();
    }

    public void OnStartButton()
    {
        GameManager.instance.StartGame();
    }

    public void OnQuitButton()
    {
        GameManager.instance.StartGame();
    }

}
