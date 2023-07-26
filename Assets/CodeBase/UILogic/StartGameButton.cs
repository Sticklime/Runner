using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CodeBase.UILogic
{
    public class StartGameButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public void AddLister(UnityAction action) => 
            _button.onClick.AddListener(action);
    }
}