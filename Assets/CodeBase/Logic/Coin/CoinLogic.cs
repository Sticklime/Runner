using UnityEngine;

namespace CodeBase.Logic.Coin
{
    [RequireComponent(typeof(SphereCollider))]
    public class CoinLogic : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            gameObject.SetActive(false);
        }
    }
}