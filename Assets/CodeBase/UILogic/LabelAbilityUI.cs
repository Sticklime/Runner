using TMPro;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class LabelAbilityUI : MonoBehaviour
    {
        [SerializeField] protected TMP_Text _levelText;
        [SerializeField] protected TMP_Text _priceText;

        public void Refresh(int level, int price)
        {
            _levelText.text = "Level " + level;
            _priceText.text = "Price " + price;
        }

        public void SetMaxLevel() => _levelText.text = "MaxLevel";
    }
}