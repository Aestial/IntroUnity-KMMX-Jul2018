using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invaders
{
    public class PlayerInput : MonoBehaviour
    {

        public float speed, health, power;

        private Camera cam;

        private Vector3 worldPosition;

        // Use this for initialization
        void Start()
        {
            cam = Camera.main;
            Debug.Log(Screen.width);
            Vector3 screenPoint = new Vector3(Screen.width, Screen.height / 2.0f, cam.nearClipPlane);
            Debug.Log(screenPoint);
            worldPosition = cam.ScreenToWorldPoint(screenPoint);
            worldPosition.z = 0.0f;
            Debug.Log(worldPosition);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("Pressed right movement key");
                transform.position += new Vector3(speed, 0, 0);
                transform.position = worldPosition;
            }

        }
    }
}


