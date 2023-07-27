using UnityEngine;

namespace CodeBase.Factory
{
    public class GameFactory : IGameFactory
    {
        private GameObject _playerPrefab;
        private GameObject _menuPrefab;
        private GameObject _hudPrefab;

        public void Load()
        {
            _menuPrefab = Resources.Load<GameObject>(PathManger.MenuPath);
            _hudPrefab = Resources.Load<GameObject>(PathManger.HudPath);
            _playerPrefab = Resources.Load<GameObject>(PathManger.PlayerPath);
        }

        public GameObject CreateMenu() =>
            Object.Instantiate(_menuPrefab, Vector3.zero, Quaternion.identity);

        public GameObject CreateHud() =>
            Object.Instantiate(_hudPrefab, Vector3.zero, Quaternion.identity);

        public GameObject CreatePlayer() =>
            Object.Instantiate(_playerPrefab, new Vector3(0, 3, 0), Quaternion.identity);
    }
}