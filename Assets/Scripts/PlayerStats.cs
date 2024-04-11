using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    float attackDamage;
    float health; 
    float attackSpeed;
    float healthRegen;
    float criticalChance;
    float criticalDamage;
    float range;
}
