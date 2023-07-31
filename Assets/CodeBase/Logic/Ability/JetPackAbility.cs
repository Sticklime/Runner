using CodeBase.Logic.Player;
using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class JetPackAbility : Ability
    {
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private PlayerAnimator _playerAnimator;
        
        private void Update()
        {
            if (!IsActive) 
                return;
            
            _playerController.StopMove();
            _playerAnimator.StateFor(AnimatorState.JetPack);
        }
    }
}