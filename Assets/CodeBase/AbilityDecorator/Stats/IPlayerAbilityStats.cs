using System;

namespace CodeBase.AbilityDecorator.Stats
{
    public  interface IPlayerAbilityStats
    {
        public int Level { get;set; }
        public int MaxLevel { set; get; }
        public bool IsActive { get; set; }
        public int TimeActive { get; set; }
        public int Price { get; set; }
    }
}