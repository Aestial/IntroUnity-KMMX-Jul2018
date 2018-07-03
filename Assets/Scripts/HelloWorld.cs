using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
	private Player player;

	// Use this for initialization
	void Start () 
	{
		player = new Player();
		player.Damage();
		print("Hello World!");
		print(player.Health);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
