using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Scripts
{
    public class PlayerManager : MonoBehaviour
    {
        #region Singleton
        private static PlayerManager _instance;

        public static PlayerManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("Player Manager is NULL");
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
        [SerializeField] private ScriptableObject playerStats;
        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private List<Animation> playerAnimations = new List<Animation>();
        [SerializeField] private Animator playerAnimationController;
        [SerializeField] protected bool isAttacking;

        private int characterLevel;
        private int playerExperience;

        [HideInInspector]public UnityEvent isAttackingEvent;
        #endregion

        void Start()
        {
            if (isAttackingEvent == null)
                isAttackingEvent = new UnityEvent();

            isAttackingEvent.AddListener(PingPlayer);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                playerAnimationController.SetTrigger("1H Attack");
            }
        }

        private void PingPlayer()
        {
            Debug.Log("Is not Attacking");
            isAttacking = false;
        }
    }
}