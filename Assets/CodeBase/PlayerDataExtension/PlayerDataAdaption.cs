using System.Linq;
using CodeBase.GeekPlay_SDK;
using CodeBase.Logic.Ability;

namespace CodeBase.PlayerDataExtension
{
    public static class PlayerDataAdaption
    {
        public static AbilityStat.Stats.AbilityStats GetAbilityStats(PlayerData playerData, AbilityType abilityType) => 
            playerData.AbilityContainer.FirstOrDefault(x => x.AbilityType == abilityType);
    }
}