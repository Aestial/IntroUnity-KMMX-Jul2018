namespace Raymundo
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ShootLaser : MonoBehaviour
    {
        public float speed;
        private Transform t;


        // Use this for initialization
        void Start()
        {
            t = GetComponent<Transform>();
            speed = 0.1f;
        }

        // Update is called once per frame
        void Update()
        {
            float y = t.localPosition.y;
            t.localPosition += new Vector3(0.0f, speed);

            if (y >= 5.0f)
            {
                Destroy(gameObject);
            }
        }
    }

}