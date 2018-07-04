using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour 
{

    public float speed;

    private Transform t;
    private float angle;

	// Use this for initialization
	void Start () 
    {
        t = GetComponent<Transform>();
        Debug.Log(t);
	}
	
	// Update is called once per frame
	void Update () 
    {
        angle = angle + speed * Time.deltaTime;
        t.eulerAngles = new Vector3(0.0f, angle, 0.0f);
	}
}
