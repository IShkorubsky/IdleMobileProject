using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

namespace Scripts
{
    public class EnemySpawner : EnemyController
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private Transform originPoint;
        [SerializeField] private float spawnRadius;
        [SerializeField] private float spawnDelay;
        private float timer;

        private void Update()
        {
            SpawnTimer();
        }

        private void SpawnEnemy(GameObject _enemyPrefab, Transform originPoint)
        {
            float directionFacing = Random.Range(0f, 360f);
            Vector3 point = Random.onUnitSphere; // Get a random point on the surface of the sphere
            point.y = 0; // Ensure the enemy spawns at the same height as the origin point
            point = point.normalized * spawnRadius; // Scale the point to the spawn radius
            point += originPoint.position; // Adjust the point relative to the origin point
            var myEnemy = Instantiate(_enemyPrefab, point, Quaternion.Euler(new Vector3(0f, directionFacing, 0f)));
            GameManager.Instance.AddEnemyToList(myEnemy);
            myEnemy.SetActive(true);
        }

        private void SpawnTimer()
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timer = spawnDelay;
                SpawnEnemy(enemyPrefab, originPoint);
            }
        }

        void OnDrawGizmos()
        {
            // Set the color for the Gizmo
            Gizmos.color = Color.red;

            // Draw a wireframe sphere at the object's position
            Gizmos.DrawWireSphere(originPoint.position, spawnRadius);
        }
    }
}
