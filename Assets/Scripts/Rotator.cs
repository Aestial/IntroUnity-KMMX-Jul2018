using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    private GameObject 
    GO;

    private Transform t;

    private float angle = 0.0f;

    public float Angle
    {
        get { return angle; }
        set { angle = value; }
    }

	//private void Awake()
	//{
    //  speed = 5.0f;
	//}

	// Use this for initialization

    void Start () 
    {
        speed = 5.0f;
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
