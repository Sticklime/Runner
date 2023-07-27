using TMPro;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class LableAbilityUI : MonoBehaviour
    {
        [SerializeField] protected TMP_Text _levelText;
        [SerializeField] protected TMP_Text _priceText;

        public void Refresh(int level, int price)
        {
            _levelText.text = level.ToString();
            _priceText.text = price.ToString();
        }

        public void SetMaxLevel()
        {
            _levelText.text = "MaxLevel";
        }
    }
}