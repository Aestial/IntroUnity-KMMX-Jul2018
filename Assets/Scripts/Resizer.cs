using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour 
{

    public float scale = 2.0f;

    private Transform t;

	// Use this for initialization
	void Start ()
    {
        t = GetComponent<Transform>();
        Debug.Log(t);
	}
	
	// Update is called once per frame
	void Update () 
    {
        t.localScale = new Vector3(scale, scale, scale);
	}
}
