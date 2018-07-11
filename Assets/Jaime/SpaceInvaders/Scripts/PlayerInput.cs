using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invaders
{
    public struct ScreenBound
    {
        public Vector3 min;
        public Vector3 max;
    }

    public struct WorldBound
    {
        public Vector2 min;
        public Vector2 max;
    }

    public class PlayerInput : MonoBehaviour
    {
        public float speed = 1.0f;
        public Vector2 playerSize;

        private Camera cam;
        private WorldBound bounds;

        // Use this for initialization
        void Start()
        {
            this.cam = Camera.main;
            this.bounds = CalculateBounds();
            this.transform.position = new Vector2(0.0f, this.bounds.min.y + playerSize.y);
        }

        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.D))
            {
                if (this.transform.position.x <= this.bounds.max.x - playerSize.x)
                {
                    Debug.Log("Move Right");
                    // For correct movement, Framerate independent
                    float x = this.speed * Time.deltaTime;
                    this.transform.position += new Vector3(x, 0, 0);
                }
                else
                    Debug.LogWarning("Limit Reached");
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (this.transform.position.x >= this.bounds.min.x + playerSize.x)
                {
                    Debug.Log("Move Left");
                    // For correct movement, Framerate independent
                    float x = this.speed * Time.deltaTime;
                    this.transform.position -= new Vector3(x, 0, 0);
                }
                else
                    Debug.LogWarning("Limit Reached");
            }
        }

        private WorldBound CalculateBounds()
        {
            ScreenBound sb;
            sb.min = new Vector3(0, 0, this.cam.nearClipPlane);
            sb.max = new Vector3(Screen.width, Screen.height, this.cam.nearClipPlane);
            WorldBound wb;
            wb.min = cam.ScreenToWorldPoint(sb.min);
            wb.max = cam.ScreenToWorldPoint(sb.max);
            return wb;
        }

    }
}


