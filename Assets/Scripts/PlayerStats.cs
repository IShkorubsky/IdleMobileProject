using System;
using UnityEngine;

[Serializable]
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
