using CodeBase.Factory;
using CodeBase.SceneLoaderServices;
using UnityEngine;

namespace CodeBase.Bootstrapper
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private GameObject _player;
        private GameObject _mainMenu;
        private GameObject _hud;

        private InitializeLevel _initializeLevel;
        private IGameFactory _gameFactory;
        private SceneLoader _sceneLoader;

        public void Start()
        {
            _sceneLoader = new SceneLoader(this);
            _gameFactory = new GameFactory();
            _gameFactory.Load();

            _initializeLevel = new InitializeLevel(_sceneLoader, _gameFactory);
            _initializeLevel.LoadLevel();
        }
    }
}