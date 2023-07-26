namespace CodeBase.Logic.Ability
{
    internal class MoneyAbility : Ability
    {
        public void Start()
        {
            TimeActive = Init.Instance.playerData.MoneyAbility.TimeActive;
        }

        private void Update()
        {
            TimerWork(this);
        }
    }
}