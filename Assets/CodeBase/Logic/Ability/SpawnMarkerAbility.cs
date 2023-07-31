using System.Collections.Generic;
using CodeBase.AbilityStat.Stats;
using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class SpawnMarkerAbility : MonoBehaviour
    {
        private readonly List<AbilityStats> _abilityStats = new List<AbilityStats>();

        public AbilityType GetTypeAbility()
        {
            foreach (AbilityStats abilityStats in Init.Instance.playerData.AbilityContainer)
            {
                if (abilityStats.IsBuy && abilityStats.AbilityType != AbilityType.Flashlight)
                    _abilityStats.Add(abilityStats);
            }

            int randomIndex = Random.Range(0, _abilityStats.Count);

            if (_abilityStats.Count > 0)
            {
                return _abilityStats[randomIndex].AbilityType;
            }
            else
                return AbilityType.None;
        }
    }
}