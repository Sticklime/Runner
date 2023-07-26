using CodeBase.UILogic;
using UnityEngine;

namespace CodeBase.Logic.Player
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private PlayerController _playerController;
        private LooseWindowUI _looseWindow;
        private ScoreCoinUI _scoreCoinUI;

        public void Construct(LooseWindowUI looseWindowUI, ScoreCoinUI scoreCoinUI)
        {
            _looseWindow = looseWindowUI;
            _scoreCoinUI = scoreCoinUI;
        }

        public void Death()
        {
            Init.Instance.playerData.CountCoin += _scoreCoinUI.CountPoint;
            _looseWindow.OpenCloseWindow(true);
            _playerController.StopMove();
            Init.Instance.Save();
        }
    }
}