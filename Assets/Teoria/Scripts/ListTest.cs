using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour 
{
    public List<string> developersList;

    public Dictionary<string, SoundFX> dict;

    public SoundFX explosionFX;

	// Use this for initialization
	void Start () 
    {
        dict = new Dictionary<string, SoundFX>();

        Debug.Log(developersList);
        Debug.Log(developersList.Count);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            developersList.Add("Jonathan");
            Debug.Log(developersList.Count);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            dict.Add("Explosion", explosionFX);
            Debug.Log(dict.Count);
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            Debug.Log(dict["Explosion"].clip);
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            PrintList();
        }
	}

    private void PrintList()
    {

        // FOR:

        for (int i = 0; i < developersList.Count; i++)
        {
            if (developersList[i] == "Jonathan")
            {
                continue;
            }
            Debug.Log(developersList[i]);

        }

        // FOREACH:

        foreach(string dev in developersList)
        {
            Debug.LogWarning(dev);
        }

        // WHILE:

        int index = 0;

        while (index < developersList.Count)
        {
            Debug.LogError(developersList[index]);
            index += 1;
        }

    }
}
