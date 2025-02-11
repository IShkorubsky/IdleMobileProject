using TMPro;
using UnityEngine;

namespace Scripts
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]PlayerStats playerStats;

        [SerializeField] private TextMeshProUGUI healthText;
        [SerializeField] private TextMeshProUGUI healthRegenText;
        [SerializeField] private TextMeshProUGUI attackDamageText;
        [SerializeField] private TextMeshProUGUI attackSpeedText;
        [SerializeField] private TextMeshProUGUI criticalChanceText;
        [SerializeField] private TextMeshProUGUI criticalDamageText;
        [SerializeField] private TextMeshProUGUI rangeText;

        private void Update()
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            healthText.text = "Health: " + playerStats.health.ToString();
            healthRegenText.text = "Health Regen: " + playerStats.healthRegen.ToString();
            attackDamageText.text = "Attack Damage: " + playerStats.attackDamage.ToString();
            attackSpeedText.text = "Attack Speed: " + playerStats.attackSpeed.ToString();
            criticalChanceText.text = "Crit Chance: " + playerStats.criticalChance.ToString();
            criticalDamageText.text = "Crit Damage: " + playerStats.criticalDamage.ToString();
            rangeText.text = "Range: " + playerStats.range.ToString();
        }
    }
}
