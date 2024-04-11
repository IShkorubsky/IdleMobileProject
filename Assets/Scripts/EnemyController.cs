using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent myNavMeshAgent;
    private Transform targetTransform;
    [SerializeField] private float stoppingDistance;

    private void Start(){
        myNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        targetTransform = GameObject.FindGameObjectWithTag("Tower").transform;
    }

    private void Update()
    {
        if (DistanceToTarget() > stoppingDistance){
            myNavMeshAgent.destination = targetTransform.position;
            Vector3.MoveTowards(transform.position, myNavMeshAgent.destination, 0.2f);
        }
        else{
            myNavMeshAgent.destination = transform.position;
        }
    }

    private float DistanceToTarget(){
        var distance = targetTransform.transform.position - transform.position;
        return distance.magnitude;
    }
}
