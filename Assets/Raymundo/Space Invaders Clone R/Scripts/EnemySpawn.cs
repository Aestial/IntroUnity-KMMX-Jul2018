﻿namespace Raymundo 
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EnemySpawn : MonoBehaviour
    {
        public GameObject prefab;
        private Transform t;
        private float wait;
        public int enemycount;
        public float speed;
        Vector3 position;

        // Use this for initialization
        void Start()
        {
            StartCoroutine(Spawner());
            wait = 0.3f;
        }

        IEnumerator Spawner()
        {
            yield return new WaitForSeconds(1.0f);
            while (enemycount < 250)
            {
                t = GetComponent<Transform>();
                position = t.position;
                GameObject newEnemy = Instantiate(prefab, position, Quaternion.identity);
                newEnemy.GetComponent<EnemyBehavior>().speed = this.speed;
                enemycount += 1;
                yield return new WaitForSecondsRealtime(wait);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

    }

}