using UnityEngine;

namespace CodeBase.Logic.Player
{
    public class GroundChecker : MonoBehaviour
    {
        private readonly float _cleavage = 0.1f;
        private readonly Collider[] _collisionsGround = new Collider[1];

        private LayerMask _groundMask;

        private void Awake() =>
            _groundMask = 1 << LayerMask.NameToLayer("Ground");

        public bool CheckGround()
        {
            int size =
                Physics.OverlapSphereNonAlloc(transform.position, _cleavage, _collisionsGround, _groundMask);
            
            return size > 0;
        }
    }
}