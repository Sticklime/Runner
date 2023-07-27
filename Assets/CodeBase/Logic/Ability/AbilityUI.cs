using System;
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

        private float _totalTime;

        public void Refresh(int countAbility)
        {
            if (_countAbilityText != null)
                _countAbilityText.text = countAbility.ToString();
        }

        public void SetValueSlider(float timeInSeconds) =>
            _totalTime = timeInSeconds;

        public void SetCurrentTime(float timeInSeconds)
        {
            float clampedTime = Mathf.Clamp(timeInSeconds, 0f, _totalTime);
            _timeActiveLabel.value = clampedTime / _totalTime;
        }
    }
}