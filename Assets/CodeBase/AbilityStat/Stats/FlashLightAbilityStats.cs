using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class FlashLightAbilityStats : AbilityStats
    {
        public FlashLightAbilityStats()
        {
            Level = 1;
            MaxLevel = 3;
            IsBuy = true;
            TimeActive = 15;
            Price = 50;
            AbilityType = AbilityType.Flashlight;
        }
    }
}