using CodeBase.Logic.Player;
using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class JetPackAbility : Ability
    {
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private PlayerAnimator _playerAnimator;

        private void Awake() =>
            TimeActive = Init.Instance.playerData.JetPackAbility.TimeActive;

        private void Update()
        {
            TimerWork();

            if (IsActive)
            {
                _playerController.StopMove();
                _playerAnimator.StateFor(AnimatorState.JetPack);
            }
        }
    }
}