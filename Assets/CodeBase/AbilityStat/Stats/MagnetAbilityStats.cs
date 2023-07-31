using System;
using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class MagnetAbilityStats : AbilityStats
    {
        public MagnetAbilityStats()
        {
            Level = 0;
            MaxLevel = 3;
            IsBuy = false;
            TimeActive = 0;
            Price = 800;
            AbilityType = AbilityType.Magnet;
        }
    }
}