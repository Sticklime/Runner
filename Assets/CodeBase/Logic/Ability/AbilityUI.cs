using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Logic.Ability
{
    public class AbilityUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _countAbilityText;
        [SerializeField] private Slider _timeActiveLabel;
        [SerializeField] public AbilityType abilityType;

        public void Refresh(int countAbility) =>
            _countAbilityText.text = countAbility.ToString();

        public void SetValueSlider(float currentTime) =>
            _timeActiveLabel.value %= currentTime;
    }
}