using UnityEngine;

namespace CodeBase.UILogic
{
    public class AddCoinAds : MonoBehaviour
    {
        [SerializeField] private ScoreCoinUI _score;

        public void WatchAdsForMoney()
        {
            Init.Instance.OnRewarded();
            _score.Refresh(Init.Instance.playerData.CountCoin);
        }
    }
}