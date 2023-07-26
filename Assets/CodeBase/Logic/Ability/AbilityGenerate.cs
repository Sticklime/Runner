using UnityEngine;
using Random = UnityEngine.Random;

namespace CodeBase.Logic.Ability
{
    public class AbilityGenerate : MonoBehaviour
    {
        private AbilityType _abilityType;

        private void OnTriggerEnter(Collider collider)
        {
            _abilityType = GetRandomAbility();

            foreach (Ability ability in collider.GetComponentsInChildren<Ability>())
            {
                if (ability.AbilityType == _abilityType)
                    ability.AddCountAbility();
            }
        }

        private AbilityType GetRandomAbility() =>
            (AbilityType)Random.Range(1, System.Enum.GetValues(typeof(AbilityType)).Length);
    }
}