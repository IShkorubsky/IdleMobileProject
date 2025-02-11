using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(LineRenderer))]
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
            DoRenderer();
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

        [Range(0, 50)]
        public int segments = 20;
        [Range(0, 5)]
        public float xradius = 5;
        [Range(0, 5)]
        public float yradius = 5;
        LineRenderer line;

        private void DoRenderer()
        {
            line = gameObject.GetComponent<LineRenderer>();
            line.positionCount = segments + 1;
            line.useWorldSpace = false;
            CreatePoints();
        }

        void CreatePoints()
        {
            float x;
            float y;

            float angle = 20f;

            for (int i = 0; i < (segments + 1); i++)
            {
                x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
                y = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

                line.SetPosition(i, new Vector3(x, 0, y));

                angle += (360f / segments);
            }
        }
    }
}