using System;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
    [Serializable]
    public class PlayerStats : ScriptableObject
    {
        [SerializeField] public float attackDamage = 1;
        [SerializeField] public float health = 1;
        [SerializeField] public float attackSpeed = 1;
        [SerializeField] public float healthRegen = 1;
        [SerializeField] public float criticalChance = 1;
        [SerializeField] public float criticalDamage = 1;
        [SerializeField] public float range = 10;


        [SerializeField] public int characterLevel = 1;
        [SerializeField] public int playerExperience = 1;
    }
}
