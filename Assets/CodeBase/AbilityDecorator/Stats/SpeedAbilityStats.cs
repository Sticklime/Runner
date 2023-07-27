using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class SpeedAbilityStats
    {
        public int Level = 0;
        public int MaxLevel = 3;
        public bool IsBuy = false;
        public int TimeActive = 0;
        public int Price = 400;
        public AbilityType AbilityType = AbilityType.Speed;
    }
}