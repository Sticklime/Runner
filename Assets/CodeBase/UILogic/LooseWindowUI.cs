using CodeBase.Bootstrapper;
using TMPro;
using UnityEngine;

namespace CodeBase.UILogic
{
    public class LooseWindowUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _currentPoint;
        [SerializeField] private TMP_Text _pointsRecord;
        [SerializeField] private ScorePointUI _scorePoint;
        [SerializeField] private GameObject _looseWindow;
        
        private InitializeLevel _initializeLevel;

        public void Construct(InitializeLevel initializeLevel)
        {
            _initializeLevel = initializeLevel;
        }
        
        public void OnEnable()
        {
            _currentPoint.text = _scorePoint.CountPoint.ToString();
            _pointsRecord.text = Init.Instance.playerData.BestResultScore.ToString();
        }

        public void OpenCloseWindow(bool isOpen) => 
            _looseWindow.SetActive(isOpen);

        public void Restart()
        {
            _initializeLevel.LoadLevel();
        }
    }
}