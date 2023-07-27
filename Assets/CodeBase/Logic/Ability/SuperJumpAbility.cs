namespace CodeBase.Logic.Ability
{
    public class SuperJumpAbility : Ability
    {
        public void Awake()
        {
            TimeActive = Init.Instance.playerData.SuperJumpAbility.TimeActive;
        }
        
        private void Update()
        {
            TimerWork();
        }
    }
}