using TMPro;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class ScoreCoinUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _countCoin;

        public int CountPoint { get; private set; }

        public void Refresh(int coin) =>
            _countCoin.text = coin.ToString();

        public void AddCoin(int reward)
        {
            CountPoint += reward;
            Refresh(CountPoint);
        }
    }
}