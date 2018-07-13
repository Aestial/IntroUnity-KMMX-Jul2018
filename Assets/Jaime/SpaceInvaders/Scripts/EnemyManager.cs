using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct ScoreText
{
    public Text textComponent;
    public string prefix;
}

public class EnemyManager : MonoBehaviour 
{
    //SINGLETON
    public static EnemyManager instance;

    public const string highscoreKey = "Highscore";

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int minEnemies;
    [SerializeField] private int maxEnemies;

    [Header("Highscore")]
    [SerializeField] private IntVariable highscoreVariable;

    [Header("UI Config")]
    [SerializeField] private ScoreText high;
    [SerializeField] private ScoreText current;

    private int count;

    private int numEnemies;

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            Debug.Log(value);
            CheckCount(value);
            UpdateScore(value);
        }
    }

    void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        //int highscore = PlayerPrefs.GetInt(highscoreKey);
        int highscore = highscoreVariable.Value;
        UpdateHighScore(highscore);
        numEnemies = Random.Range(this.minEnemies, this.maxEnemies);
        Debug.LogWarning("Number of enemies: " + numEnemies);
        //Debug.LogWarning(highscore);
    }

    public void Restart()
    {
        //Debug.LogWarning("CALLED RESTART");
        this.Count = 0;
        CreateEnemies(numEnemies);
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
        if (value >= numEnemies)
        {
            GameManager.instance.GameOver();
            highscoreVariable.Value = value;
            //PlayerPrefs.SetInt(highscoreKey, value);
            UpdateHighScore(value);
            Debug.Log(value);
        }
    }

    private void UpdateScore(int value)
    {
        current.textComponent.text = current.prefix + value.ToString();
    }

    private void UpdateHighScore(int value)
    {
        high.textComponent.text = high.prefix + value.ToString();
    }
}
