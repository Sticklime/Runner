using UnityEngine;
using UnityEngine.Playables;

namespace CodeBase.Logic.Player
{
    public class TimelineController : MonoBehaviour
    {
        [SerializeField] private PlayableDirector _playableDirector;

        public void StartTimeline() =>
            _playableDirector.Play();
    }
}