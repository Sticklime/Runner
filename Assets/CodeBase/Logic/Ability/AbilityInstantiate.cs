using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class AbilityInstantiate : MonoBehaviour
    {
        [SerializeField] private AbilityType _abilityType;

        public AbilityType AbilityType => _abilityType;

        private void OnTriggerEnter(Collider collider)
        {
            foreach (Ability ability in collider.GetComponentsInChildren<Ability>())
            {
                if (ability.AbilityType == _abilityType)
                    ability.AddCountAbility();
            }
        }
    }
}