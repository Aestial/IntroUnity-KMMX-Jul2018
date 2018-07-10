namespace Raymundo
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class LaserEffect : MonoBehaviour
    {


        // Use this for initialization
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {

        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Enemy")

            {
                //Debug.Log("Enemy hit!");
                GameObject enemy = collision.collider.gameObject;
                Score.currentscore += 10;
                Debug.Log("Score: " + Score.currentscore);
                Destroy(enemy);
                Destroy(gameObject);
            }


        }
    }

}