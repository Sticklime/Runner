using CodeBase.Logic.Coin;
using UnityEngine;

namespace CodeBase.Logic.Ability
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class MagnetAbility : Ability
    {
        private readonly float _cleavage = 0.1f;
        private readonly Collider[] _collisionsCoins = new Collider[10];

        private LayerMask _groundMask;

        private void Awake() =>
            _groundMask = 1 << LayerMask.NameToLayer("Coin");

        private void Update()
        {
            if (IsActive && CheckCoin())
            {
                
            }
        }

        private bool CheckCoin()
        {
            int size =
                Physics.OverlapSphereNonAlloc(transform.position, _cleavage, _collisionsCoins, _groundMask);

            return size > 0;
        }

        private void AttractionAtTarget(Vector3 target)
        {
            float scaledSpeed = 3 * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, transform.position + target, scaledSpeed);
        }
    }
}