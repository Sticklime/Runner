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
        [SerializeField] private Transform _groundCheck;

        private LayerMask _groundMask;
        private Collider[] _collisions = new Collider[1];
        private float _positionZ;
        private float _cleavage = 0.1f;
        private int _currentLine = 1;

        private void Awake() =>
            _groundMask = 1 << LayerMask.NameToLayer("Ground");

        private void Update()
        {
            Move();
            CheckGround();
        }

        private void Move()
        {
            if (Input.GetKeyDown(KeyCode.A) && _currentLine < 2)
            {
                _currentLine++;
                ChangeLine();
            }

            if (Input.GetKeyDown(KeyCode.D) && _currentLine > 0)
            {
                _currentLine--;
                ChangeLine();
            }

            if (Input.GetKeyUp(KeyCode.Space) && CheckGround())
                _rigidbody.AddForce(0, _jumpForce, 0);

            OnMove();
        }

        private void ChangeLine()
        {
            transform.position = 
                new Vector3( transform.position.x, transform.position.y, (_currentLine - 1) * _lineDistance);
        }

        private void OnMove()
        {
            Vector3 direction = new Vector3(1, 0, 0);
            float scaledSpeed = _moveSpeed * Time.deltaTime;

            transform.position = 
                Vector3.Lerp(transform.position, transform.position + direction, scaledSpeed);
        }

        private bool CheckGround()
        {
            int size = Physics.OverlapSphereNonAlloc(_groundCheck.position, _cleavage, _collisions, _groundMask);

            return size > 0;
        }
    }
}