using UnityEngine;

namespace CodeBase.Logic.Door
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Animator))]
    public class DoorTrigger : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        private static readonly int OpenDoor = Animator.StringToHash("OpenDoor");

        public void OnTriggerEnter(Collider collision)
        {
            _animator.SetBool(OpenDoor, true);
        }
    }
}