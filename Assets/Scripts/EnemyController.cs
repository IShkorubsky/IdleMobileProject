using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    #region Variables
    private NavMeshAgent myNavMeshAgent;
    protected Transform targetTransform;
    [SerializeField] private float stoppingDistance;
    #endregion

    private void Start()
    {
        myNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        targetTransform = GameObject.FindGameObjectWithTag("Tower").transform;
    }

    private void Update()
    {
        if (DistanceToTarget() > stoppingDistance)
        {
            myNavMeshAgent.destination = targetTransform.position;
            Vector3.MoveTowards(transform.position, myNavMeshAgent.destination, 0.1f);
        }
        else
        {
            myNavMeshAgent.destination = transform.position;
        }
    }

    #region Functions
    /// <summary>
    /// Calculate distance to the target
    /// </summary>
    /// <returns></returns>
    private float DistanceToTarget()
    {
        var distance = targetTransform.transform.position - transform.position;
        return distance.magnitude;
    }
    #endregion
}
