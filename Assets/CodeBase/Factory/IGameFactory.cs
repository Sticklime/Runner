using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.Factory
{
    public interface IGameFactory
    {
        public void Load();
        public GameObject CreateMenu();
        public GameObject CreateHud();
        public GameObject CreatePlayer();
    }
}