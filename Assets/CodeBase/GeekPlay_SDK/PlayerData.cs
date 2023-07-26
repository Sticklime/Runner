using CodeBase.AbilityDecorator.Stats;

namespace CodeBase.GeekPlay_SDK
{
    [System.Serializable]
    public class PlayerData
    {
        public FlashLightAbilityStats FlashLightAbility = new FlashLightAbilityStats();
        public MoneyAbilityStats MoneyAbility = new MoneyAbilityStats();
        public ShieldAbilityStats ShieldAbility = new ShieldAbilityStats();
        public SuperJumpAbilityStats SuperJumpAbility = new SuperJumpAbilityStats();
        public JetPackAbilityStats JetPackAbility = new JetPackAbilityStats();

        public int BestResultScore = 0;
        public int CountCoin = 10000;

        public int intTest = 0;
    }
}