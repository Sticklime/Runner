using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class FlashlightAbility : Ability
    {
        [SerializeField] private Light _light;

        private void Update() => 
            _light.enabled = IsActive;

        public override void TurnAbility()
        {
            if (IsActive)
                return;
            
            RemoveAbility();
        }
    }
}