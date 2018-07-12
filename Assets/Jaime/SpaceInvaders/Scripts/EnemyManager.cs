using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour 
{
    //SINGLETON
    public static EnemyManager instance;

    [SerializeField] private string countTextPrefix;
    [SerializeField] private int total;
    [SerializeField] private Text countText;

    private int count;

    public int Count
    {
        get { return count; }
        set { SetAndCheckCount(value); }
    }

    public void Restart()
    {
        //Instanciar objetos
        count = 0;
    }

    private void SetAndCheckCount(int value)
    {
        count = value;
        CheckCount();
        UpdateUI();
    }

    private void CheckCount()
    {
        Debug.Log("Enemies killed: " + count.ToString());
        if (count >= total)
        {
            GameManager.instance.GameOver();
        }
    }

    private void UpdateUI()
    {
        countText.text = countTextPrefix + count.ToString();
    }

    void Awake()
    {
        instance = this;    
    }

    void Start () 
    {
        Restart();
        UpdateUI();
	}
	
	void Update () 
    {
		
	}
}
