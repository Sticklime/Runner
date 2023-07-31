using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class ShieldAbilityStats : AbilityStats
    {
        public ShieldAbilityStats()
        {
            Level = 0;
            MaxLevel = 3;
            IsBuy = false;
            TimeActive = 0;
            Price = 300;
            AbilityType = AbilityType.Shield;
        }
    }
}