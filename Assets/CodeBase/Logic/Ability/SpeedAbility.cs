namespace CodeBase.Logic.Ability
{
    public class SpeedAbility : Ability
    {
        private void Awake() => 
            TimeActive = Init.Instance.playerData.SpeedAbility.TimeActive;

        private void Update() => 
            TimerWork();
    }
}