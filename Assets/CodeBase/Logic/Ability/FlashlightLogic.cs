using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class FlashlightLogic : Ability
    {
        [SerializeField] private Light _light;

        private void Awake()
        {
            TimeActive = Init.Instance.playerData.FlashLightAbility.TimeActive;
        }

        private void Update()
        {
            TimerWork(_light);
        }

        public override void TurnAbility()
        {
            if (IsActive)
                return;

            IsActive = IsActive;
            RemoveAbility();
        }
    }
}