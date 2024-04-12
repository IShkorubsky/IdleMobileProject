using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;
        private GameObject currentTarget;

        private Animator myAnimator;

        private void Start()
        {
            myAnimator = gameObject.GetComponent<Animator>();
        }

        private void Update()
        {
            if(currentTarget == null){
                currentTarget = GameManager.Instance.GetClosestEnemy();
            }
            else{
                AttackEnemy(currentTarget);
            }
        }


        //Attack closest enemy
        private void AttackEnemy(GameObject _currentTarget)
        {
            //Rotate towards closest enemy
            transform.LookAt(_currentTarget.transform.position);
            //play attack animation
            myAnimator.SetTrigger("1H Attack");
            //Spawn projectile
            //move projectile to enemy
        }
    }

}