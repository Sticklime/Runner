using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public abstract class Ability : MonoBehaviour
    {
        private AbilityUI _abilityUI;
        public AbilityType AbilityType;
        public bool IsActive { get; protected set; } = false;

        protected float TimeActive;

        private int CountAbility;

        public void Construct(AbilityUI abilityUI)
        {
            _abilityUI = abilityUI;
        }

        protected void TimerWork<T>(T component) where T : Behaviour
        {
            if (!IsActive)
            {
                component.enabled = IsActive;
                return;
            }

            if (TimeActive <= 0)
            {
                IsActive = false;
                component.enabled = IsActive;
            }

            _abilityUI.SetValueSlider(TimeActive);
            if (TimeActive > 0)
            {
                component.enabled = IsActive;
                TimeActive -= Time.deltaTime;
                Debug.Log(TimeActive);
            }
        }

        public void TurnAbility()
        {
            if (CountAbility == 0 || IsActive)
                return;

            IsActive = true;
            RemoveAbility();
        }

        public void AddCountAbility()
        {
            CountAbility++;
            _abilityUI.Refresh(CountAbility);
        }

        private void RemoveAbility()
        {
            CountAbility--;
            _abilityUI.Refresh(CountAbility);
        }
    }
}