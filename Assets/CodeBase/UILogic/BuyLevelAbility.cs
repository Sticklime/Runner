using CodeBase.AbilityStat.Stats;
using CodeBase.GeekPlay_SDK;
using CodeBase.Logic.Ability;
using CodeBase.PlayerDataExtension;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class BuyLevelAbility : MonoBehaviour
    {
        [SerializeField] private LabelAbilityUI _labelAbilityAbility;
        [SerializeField] private ScoreCoinUI _scoreCoin;
        [SerializeField] private AbilityType _abilityType;

        private PlayerData _playerData;
        private AbilityStats _abilityStats;

        public void Start()
        {
            _playerData = Init.Instance.playerData;
            _abilityStats = PlayerDataAdaption.GetAbilityStats(_playerData, _abilityType);

            RefreshUI();
        }

        public void BuyLevel()
        {
            if (TryBuy())
                Init.Instance.Save();

            RefreshUI();
        }

        private bool TryBuy()
        {
            if (_playerData.CountCoin >= _abilityStats.Price && !CheckMaxLevel())
            {
                DebitingMoney();
                AddStats();
                return true;
            }
            else
                return false;
        }

        private void RefreshUI()
        {
            if (CheckMaxLevel())
                _labelAbilityAbility.SetMaxLevel();
            else
                _labelAbilityAbility.Refresh(_abilityStats.Level, _abilityStats.Price);

            _scoreCoin.Refresh(_playerData.CountCoin);
        }

        private void AddStats()
        {
            _abilityStats.Level += 1;
            _abilityStats.TimeActive += 15;
            _abilityStats.IsBuy = true;
        }

        private bool CheckMaxLevel() => 
            _abilityStats.Level >= _abilityStats.MaxLevel;

        private void DebitingMoney() =>
            _playerData.CountCoin -= _abilityStats.Price;
    }
}