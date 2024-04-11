using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private ScriptableObject playerStats;
        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private List<Animation> playerAnimations = new List<Animation>();
        [SerializeField] private Animator playerAnimationController;
        private int characterLevel;
        private int playerExperience;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                playerAnimationController.SetTrigger("1H Attack");
            }
        }
    }
}