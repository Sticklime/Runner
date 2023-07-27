using System;
using CodeBase.Logic.Ability;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class FlashLightAbilityStats
    {
        public int Level = 1;
        public int MaxLevel = 3;
        public bool IsBuy = true;
        public int TimeActive = 0;
        public int Price = 50;
        public AbilityType AbilityType = AbilityType.Flashlight;
    }
}