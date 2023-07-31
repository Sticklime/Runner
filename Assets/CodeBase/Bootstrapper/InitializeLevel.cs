using System.Collections.Generic;
using System.Linq;
using CodeBase.Factory;
using CodeBase.Logic.Ability;
using CodeBase.Logic.Coin;
using CodeBase.Logic.Player;
using CodeBase.Pool;
using CodeBase.SceneLoaderServices;
using CodeBase.UILogic;
using UnityEngine;

namespace CodeBase.Bootstrapper
{
    public class InitializeLevel
    {
        private const string _nameGameScene = "Runner";

        private readonly SceneLoader _sceneLoader;
        private readonly IGameFactory _gameFactory;

        private List<CoinLogic> _coinContainer;
        private GameObject _mainMenu;
        private GameObject _player;
        private GameObject _hud;

        public InitializeLevel(SceneLoader sceneLoader, IGameFactory gameFactory)
        {
            _sceneLoader = sceneLoader;
            _gameFactory = gameFactory;
        }

        public void LoadLevel() =>
            InitScene();

        private void InitScene()
        {
            InitHud();
            InitPlayer();
            InitChunkPlayer();
            InitMainMenu();
            InitCoin();
            InitAbility();
        }

        private void InitChunkPlayer()
        {
            Object.FindObjectOfType<ChunkPlacer>().Construct(_player.transform);
        }

        private void InitAbility()
        {
            foreach (SpawnMarkerAbility abilitySpawn in Object.FindObjectsOfType<SpawnMarkerAbility>())
                _gameFactory.CreateAbility(abilitySpawn.GetTypeAbility(), abilitySpawn.transform);
        }

        private void InitCoin()
        {
            ObjectPool objectPool = new ObjectPool();
            _coinContainer =
                objectPool.LoadObject<CoinLogic>(Resources.Load<GameObject>(PathManger.CoinPath), 40);

            ScoreCoinUI scoreCoin = _hud.GetComponentInChildren<ScoreCoinUI>();

            foreach (CoinLogic coin in _coinContainer)
                coin.Construct(scoreCoin);
        }

        private void InitHud()
        {
            _hud = _gameFactory.CreateHud();

            _hud.GetComponent<LooseWindowUI>().Construct(this);
        }

        private void InitMainMenu()
        {
            _mainMenu = _gameFactory.CreateMenu();

            _mainMenu.GetComponentInChildren<StartGameButton>().AddLister(StarGame);
            _mainMenu.GetComponentInChildren<ScoreCoinUI>().Refresh(Init.Instance.playerData.CountCoin);
        }

        private void InitPlayer()
        {
            _player = _gameFactory.CreatePlayer();

            LooseWindowUI looseWindow = _hud.GetComponent<LooseWindowUI>();
            ScoreCoinUI scoreCoin = _hud.GetComponentInChildren<ScoreCoinUI>();
            _player.GetComponent<PlayerDeath>().Construct(looseWindow, scoreCoin);

            _hud.GetComponentInChildren<ScorePointUI>()
                .Construct(_player, _player.GetComponentInChildren<SpeedAbility>());

            List<AbilityUI> abilityUI = _hud.GetComponentsInChildren<AbilityUI>().ToList();
            foreach (Ability ability in _player.GetComponentsInChildren<Ability>())
                ability.Construct(abilityUI.First(x => x.abilityType == ability.AbilityType));
        }

        private void StarGame()
        {
            _player.GetComponent<TimelineController>().StartTimeline();
            _mainMenu.SetActive(false);
            _hud.SetActive(true);
        }
    }
}