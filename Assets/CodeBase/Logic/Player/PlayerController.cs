using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.Logic.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GroundChecker _groundCheck;
        [SerializeField] private FlashlightAbility _flashlight;
        [SerializeField] private PlayerMove _playerMove;
        [SerializeField] private MoneyAbility _moneyAbility;
        [SerializeField] private SuperJumpAbility _superJumpAbility;
        [SerializeField] private ShieldAbility _shieldAbility;
        [SerializeField] private SpeedAbility _speedAbility;
        [SerializeField] private MagnetAbility _magnetAbility;
        [SerializeField] private JetPackAbility _jetPack;

        private int _currentLine = 1;
        private bool _isMoving = false;
        private Vector2 _fingerDownPosition;
        private Vector2 _fingerUpPosition;
        private bool _detectSwipe = false;
        private float _minDistanceForSwipe = 20f;

        private void Update()
        {
            if (!_isMoving)
                return;

            if (Init.Instance.mobile)
                DetectSwipe();
            else
                PlayerControl();

            _playerMove.Move();
        }

        private void PlayerControl()
        {
            if (Input.GetKeyDown(KeyCode.A) && _currentLine < 2)
                _playerMove.ChangeLine(++_currentLine);
            if (Input.GetKeyDown(KeyCode.D) && _currentLine > 0)
                _playerMove.ChangeLine(--_currentLine);
            if (Input.GetKeyDown(KeyCode.Space) && _groundCheck.CheckGround())
                _playerMove.Jump();
            if (Input.GetKeyDown(KeyCode.Alpha1))
                _flashlight.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha2))
                _moneyAbility.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha3))
                _shieldAbility.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha4))
                _speedAbility.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha5))
                _superJumpAbility.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha6))
                _magnetAbility.TurnAbility();
            if (Input.GetKeyDown(KeyCode.Alpha7))
                _jetPack.TurnAbility();
        }

        void DetectSwipe()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fingerDownPosition = Input.mousePosition;
                _detectSwipe = true;
            }

            if (Input.GetMouseButtonUp(0) && _detectSwipe)
            {
                _fingerUpPosition = Input.mousePosition;
                CheckSwipe();
                _detectSwipe = false;
            }
        }

        void CheckSwipe()
        {
            float distanceX = _fingerUpPosition.x - _fingerDownPosition.x;
            float distanceY = _fingerUpPosition.y - _fingerDownPosition.y;

            if (Mathf.Abs(distanceX) > Mathf.Abs(distanceY) && Mathf.Abs(distanceX) > _minDistanceForSwipe)
            {
                if (distanceX > 0 && _currentLine > 0)
                    _playerMove.ChangeLine(--_currentLine);
                else if (_currentLine < 2)
                    _playerMove.ChangeLine(++_currentLine);
            }
            else if (Mathf.Abs(distanceY) > Mathf.Abs(distanceX) && Mathf.Abs(distanceY) > _minDistanceForSwipe)
            {
                if (distanceY > 0 && _groundCheck.CheckGround())
                    _playerMove.Jump();
            }
        }

        public void StopMove() =>
            _isMoving = false;

        public void StarMove() =>
            _isMoving = true;
    }
}