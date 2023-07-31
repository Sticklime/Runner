using System.Collections.Generic;
using System.Linq;
using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.Factory
{
    public class GameFactory : IGameFactory
    {
        private GameObject _playerPrefab;
        private GameObject _menuPrefab;
        private GameObject _hudPrefab;
        private GameObject _coinPrefab;
        private List<AbilityInstantiate> _abilityPrefabs;

        public void Load()
        {
            _coinPrefab = Resources.Load<GameObject>(PathManger.CoinPath);
            _menuPrefab = Resources.Load<GameObject>(PathManger.MenuPath);
            _hudPrefab = Resources.Load<GameObject>(PathManger.HudPath);
            _playerPrefab = Resources.Load<GameObject>(PathManger.PlayerPath);
            _abilityPrefabs = Resources.LoadAll<AbilityInstantiate>(PathManger.AbilityPath).ToList();
        }

        public GameObject CreateAbility(AbilityType abilityType, Transform at)
        {
            foreach (AbilityInstantiate abilityPrefab in _abilityPrefabs)
                if (abilityPrefab.AbilityType == abilityType)
                    return Object.Instantiate(abilityPrefab.gameObject, at.position, Quaternion.identity, at);

            return null;
        }

        public GameObject CreateMenu() =>
            Object.Instantiate(_menuPrefab, Vector3.zero, Quaternion.identity);

        public GameObject CreateCoin(Vector3 at) =>
            Object.Instantiate(_coinPrefab, at, Quaternion.identity);

        public GameObject CreateHud() =>
            Object.Instantiate(_hudPrefab, Vector3.zero, Quaternion.identity);

        public GameObject CreatePlayer() =>
            Object.Instantiate(_playerPrefab, new Vector3(0, 3, 0), Quaternion.identity);
    }
}

