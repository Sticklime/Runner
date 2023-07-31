using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class SuperJumpAbilityStats : AbilityStats
    {
        public SuperJumpAbilityStats()
        {
            Level = 0;
            MaxLevel = 3;
            IsBuy = false;
            TimeActive = 0;
            Price = 500;
            AbilityType = AbilityType.SuperJump;
        }
    }
}