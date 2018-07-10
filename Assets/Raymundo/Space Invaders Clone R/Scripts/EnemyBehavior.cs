namespace Raymundo 
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EnemyBehavior : MonoBehaviour
    {
        public bool movesRight;
        public float speed;
        public float dspeed;
        private Transform t;

        // Use this for initialization
        void Start()
        {
            t = GetComponent<Transform>();
            //speed = 0.1f;
            dspeed = -2.0f;
            movesRight = true;
        }

        // Update is called once per frame
        void Update()
        {
            float x = t.localPosition.x;
            float y = t.localPosition.y;

            if (x >= 11.5f)
            {
                movesRight = false;
                t.localPosition += new Vector3(0.0f, dspeed);
            }

            if (x <= -11.5f)
            {
                movesRight = true;
                t.localPosition += new Vector3(0.0f, dspeed);
            }

            if (movesRight)
            {
                t.localPosition += new Vector3(speed, 0.0f);
            }
            else
            {
                t.localPosition -= new Vector3(speed, 0.0f);
            }

            if (y == -4.0f)
            {
                Debug.LogError("You lose!");
                Destroy(GameObject.Find("Player"));
            }

        }
    }

}
