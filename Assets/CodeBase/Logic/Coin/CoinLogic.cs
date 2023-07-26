using CodeBase.Logic.Ability;
using CodeBase.Logic.Player;
using CodeBase.UILogic;
using UnityEngine;

namespace CodeBase.Logic.Coin
{
    [RequireComponent(typeof(SphereCollider))]
    public class CoinLogic : MonoBehaviour
    {
        private ScoreCoinUI _scoreCoinUI;
        private int _reward = 1;

        public void Construct(ScoreCoinUI scoreCoinUI) =>
            _scoreCoinUI = scoreCoinUI;

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.TryGetComponent(out PlayerController playerController))
            {
                gameObject.SetActive(false);
                if (collision.GetComponentInChildren<MoneyAbility>().IsActive)
                {
                    AddPoints(_reward * 2);
                    return;
                }
                AddPoints(_reward);
            }
        }

        private void AddPoints(int reward)
        {
            _scoreCoinUI.AddCoin(reward);
        }
    }
}