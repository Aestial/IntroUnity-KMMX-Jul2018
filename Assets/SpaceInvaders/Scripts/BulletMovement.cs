using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10;

    private Transform transform;

	void Start () 
    {
        transform = GetComponent<Transform>();
	}
	
	void Update () 
    {
        float y = Time.deltaTime * speed;
        transform.position += new Vector3(0.0f, y);
	}
}
