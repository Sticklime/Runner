using System;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class FlashLightAbilityStats : IPlayerAbilityStats
    {
        public int Level { get; set; } = 1;
        public int MaxLevel { get; set; } = 3;
        public bool IsActive { get; set; } = true;
        public int TimeActive { get; set; } = 10;
        public int Price { get; set; } = 50;
        public int BatteryCharge = 10;
    }
}