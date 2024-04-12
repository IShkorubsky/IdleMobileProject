using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Scripts
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("Game Manager is NULL");
                }
                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }
        #endregion

        #region Variables

        private int gameLevel;

        [SerializeField] private List<GameObject> enemies;

        #endregion Variables

        public void AddEnemyToList(GameObject enemy){
            enemies.Add(enemy.gameObject);
        }

        public GameObject GetClosestEnemy(){
            if(enemies == null){
                Debug.LogError("Enemy list is empty");
            }
            return enemies[0];
        }
    }
}

