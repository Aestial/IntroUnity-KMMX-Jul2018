using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private Player player;

    public int lifes;

    public float height = 5.0f;
    public float headHeight = 5.0f;
    public float shouldersHeight = 5.0f;

    public int numFriends = 666;
    public string nickName = "ALMO";

    public bool isSleeping = false;
    public bool hasEaten = true;

	// Use this for initialization
	void Start () 
    {
        player = new Player();
        player.Damage();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

}
