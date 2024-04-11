using System.Collections.Generic;
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

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

