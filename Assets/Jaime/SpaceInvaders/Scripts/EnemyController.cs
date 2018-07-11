using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
    private Animator animator;

	void Start () 
    {
        animator = GetComponent<Animator>();	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
        Debug.Log(collision.otherRigidbody.gameObject.name);
        Debug.Log(collision.collider.gameObject.name);
        if (collision.collider.gameObject.tag == "Bullet")
        {
            GameObject bullet = collision.collider.gameObject;
            Destroy(bullet);
            animator.SetTrigger("OnDieTrigger");    
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        GameManager.instance.GameOver();
    }

    void Update () 
    {
		
	}
}
