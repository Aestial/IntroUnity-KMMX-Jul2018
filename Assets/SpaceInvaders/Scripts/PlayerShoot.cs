using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
    public GameObject prefab;

    Transform transform;
    Vector3 position;

	void Start () 
    {
        transform = GetComponent<Transform>();
	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            position = transform.position;
            Debug.Log("Player Shoot!!!");
            Instantiate(prefab, position, Quaternion.identity);
        }
	}
}
