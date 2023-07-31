using CodeBase.PlayerDataExtension;
using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public abstract class Ability : MonoBehaviour
    {
        private AbilityUI _abilityUI;
        private AbilityStat.Stats.AbilityStats _abilityStats;
        private int _countAbility;
        private float _timeActive;

        public AbilityType AbilityType;

        public bool IsActive { get; private set; }

        public void Construct(AbilityUI abilityUI) =>
            _abilityUI = abilityUI;

        private void Update() =>
            TimerWork();

        private void TimerWork()
        {
            _abilityUI.gameObject.SetActive(_countAbility > 0 || IsActive);

            if (IsActive == false || _timeActive <= 0)
                IsActive = false;
            else
            {
                _timeActive -= Time.deltaTime;
                Debug.Log(_timeActive);
            }

            _abilityUI.SetCurrentTime(_timeActive);
        }

        public virtual void TurnAbility()
        {
            _abilityStats = PlayerDataAdaption.GetAbilityStats(Init.Instance.playerData, AbilityType);

            if (_countAbility <= 0 || IsActive)
                return;

            _abilityUI.SetValueSlider(_timeActive);

            _timeActive = _abilityStats.TimeActive;
            IsActive = true;

            RemoveAbility();
        }

        public void AddCountAbility()
        {
            _countAbility++;
            _abilityUI.Refresh(_countAbility);
        }

        protected void RemoveAbility()
        {
            _countAbility--;
            _abilityUI.Refresh(_countAbility);
        }
    }
}