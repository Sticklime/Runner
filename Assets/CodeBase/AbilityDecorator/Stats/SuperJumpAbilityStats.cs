using System;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class SuperJumpAbilityStats : IPlayerAbilityStats
    {
        public int JumpForce = 2;
        public int Level { get; set; } = 0;
        public int MaxLevel { get; set; } = 3;
        public bool IsActive { get; set; } = false;
        public int TimeActive { get; set; } = 0;
        public int Price { get; set; } = 500;
    }
}