using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootInput : MonoBehaviour 
{
    public GameObject prefab;
    private Transform t;
    Vector3 position;
	
    // Use this for initialization
	void Start () 
    {
        t = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            position = transform.position;
            //Debug.Log("Player Shoots!");
            Instantiate(prefab, position, Quaternion.identity);
        }
	}
}
