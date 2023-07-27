namespace CodeBase.Logic.Ability
{
    public class ShieldAbility : Ability
    {
        private void Awake()
        {
            TimeActive = Init.Instance.playerData.ShieldAbility.TimeActive;
        }

        private void Update()
        {
            TimerWork();
        }
    }
}