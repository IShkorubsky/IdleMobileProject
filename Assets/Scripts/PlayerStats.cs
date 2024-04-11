using System;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
    [Serializable]
    public class PlayerStats : ScriptableObject
    {
        [SerializeField] private float attackDamage;
        [SerializeField] private float health;
        [SerializeField] private float attackSpeed;
        [SerializeField] private float healthRegen;
        [SerializeField] private float criticalChance;
        [SerializeField] private float criticalDamage;
        [SerializeField] private float range;
    }
}
