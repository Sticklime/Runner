using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class MoneyAbilityStats : AbilityStats
    {
        public MoneyAbilityStats()
        {
            Level = 0;
            MaxLevel = 3;
            IsBuy = false;
            TimeActive = 0;
            Price = 100;
            AbilityType = AbilityType.MoneyMultiplier;
        }
    }
}