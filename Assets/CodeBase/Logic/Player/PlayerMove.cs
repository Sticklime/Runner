using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.Logic.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private int _moveSpeed = 5;
        [SerializeField] private int _jumpForce = 300;
        [SerializeField] public float _lineDistance = 3f;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private SuperJumpAbility _superJumpAbility;

        private float _positionZ;

        public void Move()
        {
            Vector3 direction = new Vector3(1, 0, 0);
            float scaledSpeed = _moveSpeed * Time.deltaTime;

            transform.position =
                Vector3.Lerp(transform.position, transform.position + direction, scaledSpeed);
        }

        public void Jump()
        {
            if (_superJumpAbility.IsActive)
                _rigidbody.AddForce(0, _jumpForce * 2, 0);

            _rigidbody.AddForce(0, _jumpForce, 0);
        }

        public void ChangeLine(int _currentLine)
        {
            transform.position =
                new Vector3(transform.position.x, transform.position.y, (_currentLine - 1) * _lineDistance);
        }
    }
}