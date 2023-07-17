using UnityEngine;

namespace CodeBase.Logic.Player
{
    public class PlayerDeath : MonoBehaviour
    {
        public void Death() => 
            gameObject.SetActive(false);
    }
}