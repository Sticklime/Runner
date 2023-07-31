using CodeBase.Logic.Ability;
using TMPro;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class ScorePointUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;

        private SpeedAbility _speedAbility;
        private GameObject _player;

        public int CountPoint { get; private set; }

        public void Construct(GameObject player, SpeedAbility speedAbility)
        {
            _player = player;
            _speedAbility = speedAbility;
        }

        private void Update()
        {
            if (_speedAbility.IsActive)
                CountPoint = (int)_player.transform.position.x * 2;

            CountPoint = (int)_player.transform.position.x;
            RefreshData(CountPoint);

            if (CountPoint > Init.Instance.playerData.BestResultScore)
            {
                Init.Instance.playerData.BestResultScore = CountPoint;
            }
        }

        private void RefreshData(int countPoint)
        {
            _scoreText.text = countPoint.ToString();
        }
    }
}