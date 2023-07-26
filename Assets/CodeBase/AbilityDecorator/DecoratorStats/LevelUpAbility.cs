using CodeBase.AbilityDecorator.Provider;
using CodeBase.AbilityDecorator.Stats;
using UnityEngine;

namespace CodeBase.AbilityDecorator.DecoratorStats
{
    public class LevelUpAbility : AbilityDecorator
    {
        private readonly IAbilityProvider _abilityProvider;
        private readonly IPlayerAbilityStats _abilityStats;


        public LevelUpAbility(IAbilityProvider abilityProvider, IPlayerAbilityStats abilityStats) : base(abilityProvider, abilityStats)
        {
            _abilityProvider = abilityProvider;
            _abilityStats = abilityStats;
        }

        protected override IPlayerAbilityStats GetStatsDecorator()
        {
            _abilityStats.Level++;
            _abilityStats.IsActive = true;

            return _abilityStats;
        }
    }
}