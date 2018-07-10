namespace Ivan
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EnemyBulletController : MonoBehaviour
    {
        public Transform bullet;

        public float speed;

        // Use this for initialization
        void Start()
        {
            bullet = GetComponent<Transform>();
        }

        void FixedUpdate()
        {
            bullet.position += Vector3.up * -speed;
            if (bullet.position.y <= 9)
                Destroy(gameObject);
        }
        // Update is called once per frame
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Destroy(other.gameObject);
                Destroy(gameObject);

                GameOver.isPlayerDead = true;
            }
            else if (other.tag == "Base")
            {
                GameObject playerBase = other.gameObject;
                BaseHealth baseHealt = playerBase.GetComponent<BaseHealth>();
                baseHealt.health -= 1;
                Destroy(gameObject);
            }
        }
    }
}
