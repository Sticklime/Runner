using CodeBase.AbilityDecorator.Provider;
using CodeBase.AbilityDecorator.Stats;

namespace CodeBase.AbilityDecorator.DecoratorStats
{
    public class FlashLightUpLevel : AbilityDecorator
    {
        private readonly FlashLightAbilityStats _abilityStats;

        public FlashLightUpLevel(IAbilityProvider abilityProvider, FlashLightAbilityStats abilityStats) : base(abilityProvider, abilityStats)
        {
            _abilityStats = abilityStats;
        }

        protected override IPlayerAbilityStats GetStatsDecorator()
        {
            _abilityStats.BatteryCharge += 10;
            
            return _abilityStats;
        }
    }
}