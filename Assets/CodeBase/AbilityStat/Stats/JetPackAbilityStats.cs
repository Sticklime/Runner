using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class JetPackAbilityStats : AbilityStats
    {
        public JetPackAbilityStats()
        {
            Level = 0;
            MaxLevel = 1;
            IsBuy = false;
            TimeActive = 0;
            Price = 800;
            AbilityType = AbilityType.JetPack;
        }
    }
}