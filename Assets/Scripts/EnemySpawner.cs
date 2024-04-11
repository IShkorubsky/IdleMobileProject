using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using UnityEngine;

namespace Scripts
{
    public class EnemySpawner : EnemyController
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private float spawnDelay;
        private float timer;

        private void Update()
        {
            SpawnTimer();
        }

        private void SpawnEnemy(GameObject _enemyPrefab, Transform _spawnPosition)
        {
            if (enemyPrefab != null)
            {
                var myEnemy = Instantiate(_enemyPrefab, _spawnPosition.position, transform.rotation);
                //enemies missing rotation towards target
                myEnemy.SetActive(true);
            }
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
                SpawnEnemy(enemyPrefab, spawnPosition);
            }
        }
    }
}
