namespace Raymundo
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerInput : MonoBehaviour
    {
        public float speed;
        private Transform t;

        // Use this for initialization
        void Start()
        {
            t = GetComponent<Transform>();
            speed = 0.18f;
        }

        // Update is called once per frame
        void Update()
        {
            float x = t.localPosition.x;
            if (Input.GetKey(KeyCode.D))
            {
                if (x <= 11.5f)
                {
                    t.localPosition += new Vector3(speed, 0.0f);
                }
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (x >= -11.5f)
                {
                    t.localPosition -= new Vector3(speed, 0.0f);
                }
            }
        }
    }

}