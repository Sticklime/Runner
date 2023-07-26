using UnityEngine;

namespace CodeBase.Logic.Ability
{
    public class FlashlightLogic : Ability
    {
        [SerializeField] private Light _light;
        
        private void Start()
        {
            TimeActive = Init.Instance.playerData.FlashLightAbility.BatteryCharge;
        }
        
        private void Update()
        {
            TimerWork(_light);
        }
    }
}