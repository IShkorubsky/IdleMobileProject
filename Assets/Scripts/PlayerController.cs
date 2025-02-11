using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerController : PlayerManager
    {
        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameObject projectilePrefab;
        [SerializeField] private Transform projectileSpawn;
        [SerializeField] private float projectileSpeed;
        private GameObject currentTarget;

        private Animator myAnimator;

        private void Start()
        {
            myAnimator = gameObject.GetComponent<Animator>();
        }

        private void Update()
        {
            if (currentTarget == null)
            {
                currentTarget = GameManager.Instance.GetClosestEnemy();
            }

            if (!isAttacking && currentTarget != null)
            {
                AttackEnemy(currentTarget);
            }
        }

        //Attack closest enemy
        private void AttackEnemy(GameObject _currentTarget)
        {
            //Rotate towards closest enemy
            transform.LookAt(_currentTarget.transform, Vector3.up);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            //play attack animation
            myAnimator.SetTrigger("1H Attack");
            isAttacking = true;
        }

        public void SpawnProjectile()
        {
            //Spawn projectile
            var myProjectile = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);
            //calculate direction to nemy
            var direction = transform.position - currentTarget.transform.position;
            //move projectile to enemy
            myProjectile.GetComponent<Rigidbody>().AddForce(-direction * projectileSpeed, ForceMode.Force);
        }
    }
}