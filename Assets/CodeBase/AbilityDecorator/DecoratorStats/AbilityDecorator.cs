using CodeBase.AbilityDecorator.Provider;
using CodeBase.AbilityDecorator.Stats;

namespace CodeBase.AbilityDecorator.DecoratorStats
{
    public abstract class AbilityDecorator : IAbilityProvider
    {
        protected AbilityDecorator(IAbilityProvider abilityProvider, IPlayerAbilityStats abilityStats)
        {
        }

        public IPlayerAbilityStats GetStats() =>
            GetStatsDecorator();

        protected abstract IPlayerAbilityStats GetStatsDecorator();
    }
}