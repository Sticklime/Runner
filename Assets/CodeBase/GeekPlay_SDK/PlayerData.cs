using CodeBase.AbilityDecorator.Stats;

namespace CodeBase.GeekPlay_SDK
{
    [System.Serializable]
    public class PlayerData
    {
        public FlashLightAbilityStats FlashLightAbility;
        public MoneyAbilityStats MoneyAbility;
        public ShieldAbilityStats ShieldAbility;
        public SuperJumpAbilityStats SuperJumpAbility;
        public JetPackAbilityStats JetPackAbility;
        public SpeedAbilityStats SpeedAbility;

        public int BestResultScore = 0;
        public int CountCoin;
    }
}