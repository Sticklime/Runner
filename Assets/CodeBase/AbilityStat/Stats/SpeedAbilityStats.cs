using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class SpeedAbilityStats : AbilityStats
    {
        public SpeedAbilityStats()
        {
            Level = 0;
            MaxLevel = 3;
            IsBuy = false;
            TimeActive = 0;
            Price = 400;
            AbilityType = AbilityType.Speed;
        }
    }
}