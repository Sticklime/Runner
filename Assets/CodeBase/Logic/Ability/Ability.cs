using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public abstract class Ability : MonoBehaviour
    {
        private AbilityUI _abilityUI;
        private int CountAbility = 0;

        public AbilityType AbilityType;

        protected float TimeActive;
        public bool IsActive { get; protected set; } = false;

        public void Construct(AbilityUI abilityUI)
        {
            _abilityUI = abilityUI;
        }

        public void Start() =>
            _abilityUI.SetValueSlider(TimeActive);

        protected void TimerWork<T>(T component = null) where T : Behaviour
        {
            if (IsActive == false || TimeActive >= 0)
            {
                IsActive = false;
                component.enabled = false;
                return;
            }
            else
                TimeActive -= Time.deltaTime;


            Debug.Log(TimeActive);
            _abilityUI.SetCurrentTime(TimeActive);
        }

        protected void TimerWork()
        {
            _abilityUI.gameObject.SetActive(CountAbility > 0 || IsActive);

            if (IsActive == false || TimeActive <= 0)
            {
                IsActive = false;
                return;
            }
            else
                TimeActive -= Time.deltaTime;

            Debug.Log(TimeActive);
            _abilityUI.SetCurrentTime(TimeActive);
        }

        public virtual void TurnAbility()
        {
            if (CountAbility <= 0 || IsActive)
                return;

            IsActive = true;
            enabled = true;

            RemoveAbility();
        }

        public void AddCountAbility()
        {
            CountAbility++;
            _abilityUI.Refresh(CountAbility);
        }

        protected void RemoveAbility()
        {
            CountAbility--;
            _abilityUI.Refresh(CountAbility);
        }
    }
}