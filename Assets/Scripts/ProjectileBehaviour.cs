using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;
using UnityEngine.Events;

public class ProjectileBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")){
            Debug.Log("Enemy Hit!");
            PlayerManager.Instance.isAttackingEvent.Invoke();
            GameManager.Instance.RemoveEnemyFromList(other.gameObject);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
