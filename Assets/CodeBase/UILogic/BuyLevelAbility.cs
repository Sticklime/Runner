using CodeBase.AbilityDecorator.DecoratorStats;
using CodeBase.AbilityDecorator.Provider;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class BuyLevelAbility : MonoBehaviour
    {
        [SerializeField] private ScoreCoinUI _scoreCoin;
        private IAbilityProvider _abilityProvider;

        public void BuyFleshLightLevel()
        {
            if (TryBuy(Init.Instance.playerData.FlashLightAbility.Price))
            {
                new LevelUpAbility(_abilityProvider, Init.Instance.playerData.FlashLightAbility).GetStats();
                new FlashLightUpLevel(_abilityProvider, Init.Instance.playerData.FlashLightAbility).GetStats();
                Init.Instance.Save();
            }
        }

        public void BuySuperJumpAbility()
        {
            if (TryBuy(Init.Instance.playerData.SuperJumpAbility.Price))
            {
                new LevelUpAbility(_abilityProvider, Init.Instance.playerData.SuperJumpAbility).GetStats();
                Init.Instance.Save();
            }
        }

        public void BuyJetPackAbility()
        {
            if (TryBuy(Init.Instance.playerData.JetPackAbility.Price))
            {
                new LevelUpAbility(_abilityProvider, Init.Instance.playerData.JetPackAbility).GetStats();
                Init.Instance.Save();
            }
        }

        public void BuyShieldAbility()
        {
            if (TryBuy(Init.Instance.playerData.ShieldAbility.Price))
            {
                new LevelUpAbility(_abilityProvider, Init.Instance.playerData.ShieldAbility).GetStats();
                Init.Instance.Save();
            }
        }

        public void BuyMoneyAbility()
        {
            if (TryBuy(Init.Instance.playerData.MoneyAbility.Price))
            {
                new LevelUpAbility(_abilityProvider, Init.Instance.playerData.MoneyAbility).GetStats();
                Init.Instance.Save();
            }
        }

        private bool TryBuy(int price)
        {
            if (Init.Instance.playerData.CountCoin >= price)
            {
                Init.Instance.playerData.CountCoin -= price;
                return true;
            }

            _scoreCoin.Refresh(Init.Instance.playerData.CountCoin);
            return false;
        }
    }
}