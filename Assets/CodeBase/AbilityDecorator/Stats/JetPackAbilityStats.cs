using System;
using UnityEngine;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class JetPackAbilityStats : IPlayerAbilityStats
    {
        public int Level { get; set; } = 0;
        public int MaxLevel { get; set; } = 1;
        public bool IsActive { get; set; } = false;
        public int TimeActive { get; set; } = 0;
        public int Price { get; set; } = 800;
    }
}