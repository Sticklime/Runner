namespace CodeBase.Logic.Ability
{
    public class ShieldAbility : Ability
    {
        private void Start()
        {
            TimeActive = Init.Instance.playerData.ShieldAbility.TimeActive;
        }

        private void Update()
        {
            TimerWork(this);
        }
    }
}