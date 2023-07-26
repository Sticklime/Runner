using CodeBase.Logic.Ability;
using CodeBase.Logic.Player;
using UnityEngine;

namespace CodeBase.Obstacle
{
    [RequireComponent(typeof(BoxCollider))]
    public class DeathTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            if (!collision.TryGetComponent(out PlayerDeath playerDeath))
                return;

            if (playerDeath.gameObject.GetComponentInChildren<ShieldAbility>().IsActive)
                return;

            playerDeath.Death();
        }
    }
}