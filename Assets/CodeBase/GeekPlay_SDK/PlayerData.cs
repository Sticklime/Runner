using System;
using System.Collections.Generic;
using CodeBase.AbilityStat.Stats;

namespace CodeBase.GeekPlay_SDK
{
    [Serializable]
    public class PlayerData
    {
        public FlashLightAbilityStats FlashLightAbility = new FlashLightAbilityStats();
        public MoneyAbilityStats MoneyAbility = new MoneyAbilityStats();
        public ShieldAbilityStats ShieldAbility = new ShieldAbilityStats();
        public SuperJumpAbilityStats SuperJumpAbility = new SuperJumpAbilityStats();
        public JetPackAbilityStats JetPackAbility = new JetPackAbilityStats();
        public SpeedAbilityStats SpeedAbility = new SpeedAbilityStats();
        public MagnetAbilityStats MagnetAbilityStats = new MagnetAbilityStats();

        public List<AbilityStats> AbilityContainer = new List<AbilityStats>();

        public int BestResultScore = 0;
        public int CountCoin = 0;

        public PlayerData()
        {
            AbilityContainer.Add(MagnetAbilityStats);
            AbilityContainer.Add(FlashLightAbility);
            AbilityContainer.Add(MoneyAbility);
            AbilityContainer.Add(ShieldAbility);
            AbilityContainer.Add(SuperJumpAbility);
            AbilityContainer.Add(JetPackAbility);
            AbilityContainer.Add(SpeedAbility);
        }
    }
}