using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour 
{
    //SINGLETON
    public static EnemyManager instance;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int enemyCount;
    [SerializeField] private string countTextPrefix;
    //[SerializeField] private int total;
    [SerializeField] private Text countText;

    private int count;

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            Debug.Log(value);
            CheckCount(value);
            UpdateUI(value);
        }
    }

    void Awake()
    {
        instance = this;    
    }

    //void OnEnable() 
    //{
    //    Restart();
    //}

    public void Restart()
    {
        Debug.LogWarning("CALLED RESTART");
        this.Count = 0;
        CreateEnemies(this.enemyCount);
    }

    private void CreateEnemies(int num)
    {
        Debug.Log(num);
        for (int i = 0; i < num; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, this.transform);
        }
    }

    private void CheckCount(int value)
    {
        Debug.Log("Enemies killed: " + value.ToString());
        if (value >= enemyCount)
        {
            GameManager.instance.GameOver();
        }
    }

    private void UpdateUI(int value)
    {
        countText.text = countTextPrefix + value.ToString();
    }

   
}
