using CodeBase.GeekPlay_SDK;
using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class BuyLevelAbility : MonoBehaviour
    {
        [SerializeField] private ScoreCoinUI _scoreCoin;
        [SerializeField] private LableAbilityUI _lableAbilityAbility;
        [SerializeField] private AbilityType _abilityType;

        private PlayerData _playerData;

        public void Start()
        {
            _playerData = Init.Instance.playerData;

            switch (_abilityType)
            {
                case AbilityType.Flashlight:
                    Refresh(_playerData.FlashLightAbility.Level, _playerData.FlashLightAbility.Price,
                        _playerData.FlashLightAbility.MaxLevel);
                    return;
                case AbilityType.MoneyMultiplier:
                    Refresh(_playerData.MoneyAbility.Level, _playerData.MoneyAbility.Price,
                        _playerData.MoneyAbility.MaxLevel);
                    return;
                case AbilityType.Shield:
                    Refresh(_playerData.ShieldAbility.Level, _playerData.ShieldAbility.Price,
                        _playerData.ShieldAbility.MaxLevel);
                    return;
                case AbilityType.Speed:
                    Refresh(_playerData.SpeedAbility.Level, _playerData.SpeedAbility.Price,
                        _playerData.SpeedAbility.MaxLevel);
                    return;
                case AbilityType.JetPack:
                    Refresh(_playerData.JetPackAbility.Level, _playerData.JetPackAbility.Price,
                        _playerData.JetPackAbility.MaxLevel);
                    return;
                case AbilityType.SuperJump:
                    Refresh(_playerData.SuperJumpAbility.Level, _playerData.SuperJumpAbility.Price,
                        _playerData.SuperJumpAbility.MaxLevel);
                    return;
            }
        }

        public void BuyFleshLightLevel()
        {
            if (TryBuy(_playerData.FlashLightAbility.Price, _playerData.FlashLightAbility.Level,
                    _playerData.FlashLightAbility.MaxLevel))
            {
                _playerData.FlashLightAbility.Level += 1;
                _playerData.FlashLightAbility.TimeActive += 15;
                
                Refresh(_playerData.FlashLightAbility.Level, _playerData.FlashLightAbility.Price,
                    _playerData.FlashLightAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        public void BuySuperJumpAbility()
        {
            if (TryBuy(_playerData.SuperJumpAbility.Price, _playerData.SuperJumpAbility.Level,
                    _playerData.SuperJumpAbility.MaxLevel))
            {
                _playerData.SuperJumpAbility.Level += 1;
                _playerData.SuperJumpAbility.TimeActive += 15;
                
                Refresh(_playerData.SuperJumpAbility.Level, _playerData.SuperJumpAbility.Price,
                    _playerData.SuperJumpAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        public void BuySpeedAbility()
        {
            if (TryBuy(_playerData.SpeedAbility.Price, _playerData.SpeedAbility.Level,
                    _playerData.SpeedAbility.MaxLevel))
            {
                _playerData.SpeedAbility.Level += 1;
                _playerData.SpeedAbility.TimeActive += 15;
                
                Refresh(_playerData.SpeedAbility.Level, _playerData.SpeedAbility.Price,
                    _playerData.SpeedAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        public void BuyJetPackAbility()
        {
            if (TryBuy(_playerData.JetPackAbility.Price, _playerData.JetPackAbility.Level,
                    _playerData.JetPackAbility.MaxLevel))
            {
                _playerData.JetPackAbility.Level += 1;
                _playerData.JetPackAbility.TimeActive += 15;
                
                Refresh(_playerData.JetPackAbility.Level, _playerData.JetPackAbility.Price,
                    _playerData.JetPackAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        public void BuyShieldAbility()
        {
            if (TryBuy(_playerData.ShieldAbility.Price, _playerData.ShieldAbility.Level,
                    _playerData.ShieldAbility.MaxLevel))
            {
                _playerData.ShieldAbility.Level += 1;
                _playerData.ShieldAbility.TimeActive += 15;
                
                Refresh(_playerData.ShieldAbility.Level, _playerData.ShieldAbility.Price,
                    _playerData.ShieldAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        public void BuyMoneyAbility()
        {
            if (TryBuy(_playerData.MoneyAbility.Price, _playerData.MoneyAbility.Level,
                    _playerData.MoneyAbility.MaxLevel))
            {
                _playerData.MoneyAbility.Level += 1;
                _playerData.MoneyAbility.TimeActive += 15;
                
                Refresh(_playerData.MoneyAbility.Level, _playerData.MoneyAbility.Price,
                    _playerData.MoneyAbility.MaxLevel);
                
                Init.Instance.Save();
            }
        }

        private bool TryBuy(int price, int level, int maxLevel)
        {

            if (CheckMaxLevel(level, maxLevel))
            {
                _lableAbilityAbility.SetMaxLevel();
                _scoreCoin.Refresh(Init.Instance.playerData.CountCoin);
                return false;
            }
               
            if (Init.Instance.playerData.CountCoin >= price)
            {
                Init.Instance.playerData.CountCoin -= price;

                return true;
            }

            _scoreCoin.Refresh(Init.Instance.playerData.CountCoin);
            return false;
        }

        private void Refresh(int level, int price, int maxLevel)
        {
            if (CheckMaxLevel(level, maxLevel))
            {
                _scoreCoin.Refresh(Init.Instance.playerData.CountCoin);
                _lableAbilityAbility.SetMaxLevel();
                return;
            }

            _lableAbilityAbility.Refresh(level, price);
            _scoreCoin.Refresh(Init.Instance.playerData.CountCoin);
        }

        private bool CheckMaxLevel(int level, int maxLevel) =>
            level == maxLevel;
    }
}