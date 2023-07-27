using UnityEngine;

namespace CodeBase.Logic.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] public Animator _animator;

        private readonly int _idleStateHash = Animator.StringToHash("Idle");
        private readonly int _walkingStateHash = Animator.StringToHash("Shake");
        private readonly int _jetPack = Animator.StringToHash("JetPack");
        
        private void PlayJetPack() =>
            _animator.Play(_jetPack);

        private void PlayRun() =>
            _animator.Play(_walkingStateHash);

        private void ResetToIdle() =>
            _animator.Play(_idleStateHash);

        public void StateFor(AnimatorState animatorState)
        {
            if (animatorState == AnimatorState.Idle)
                ResetToIdle();
            else if (animatorState == AnimatorState.Run)
                PlayRun();
            else if (animatorState == AnimatorState.JetPack)
                PlayJetPack();
            else
                PlayJetPack();
        }
    }
}