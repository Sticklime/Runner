using CodeBase.AbilityDecorator.Stats;

namespace CodeBase.AbilityDecorator.Provider
{
    public interface IAbilityProvider
    {
        public IPlayerAbilityStats GetStats();
    }
}