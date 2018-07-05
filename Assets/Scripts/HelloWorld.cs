using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
    public bool isFemale;
    public bool isAdult;

    private float happyness = 0.0f;
    private float mischievous = 1.0f;

    void Awake()
	{
        if (isFemale && isAdult)
        {
            print("She's awakening");
            print("She's VERY HUNGRY");
            happyness = 0.1f;
            if (mischievous < 1.5f)
            {
                print("She's a good girl");
            }
            else
            {
                print("She's very naugthy");   
            }
        }
        else if(!isAdult)
        {
            print("It's a kid!!");
            happyness = 2.0f;
        }
        else
        {
            print("He's awakening");
            print("He's sleepy");
            happyness = 1.0f;
        }
        //if (calculateMischievous)
        //{
        //    mischievous = (!isAdult && !isFemale) ? 5.25f : 0.5f;
    
        //}

        Debug.Log(happyness);
        Debug.Log(mischievous);
    }

	private void OnEnable()
	{
        print("On enable message");
	}
	// Use this for initialization
	void Start () 
	{
		print("Hello World! - Start");
	}
	
	// Update is called once per frame
	void Update () 
	{
        print("Update message");
	}

    public void UpdateMessage(string newMessage)
    {
        
        
    }

    private void CheckMessage()
    {
        
    }
}
