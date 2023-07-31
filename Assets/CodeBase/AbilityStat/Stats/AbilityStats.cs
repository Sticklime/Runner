using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityStat.Stats
{
    [Serializable]
    public class AbilityStats
    {
        public int Level;
        public int MaxLevel;
        public bool IsBuy;
        public int TimeActive;
        public int Price;
        public AbilityType AbilityType;
    }
}