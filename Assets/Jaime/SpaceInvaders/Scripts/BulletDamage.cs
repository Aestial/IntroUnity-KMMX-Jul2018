using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour 
{

	void Start () 
    {
		
	}
	
	void Update () 
    {
        	
	}

    private void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("Collision Detected");
        Debug.Log(collision.otherRigidbody.gameObject.name);
        Debug.Log(collision.collider.gameObject.name);
        GameObject enemy = collision.collider.gameObject;
        Destroy(enemy);
        Destroy(gameObject);
	}
}
