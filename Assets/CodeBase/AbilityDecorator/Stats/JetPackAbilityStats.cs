using System;
using CodeBase.Logic.Ability;
using UnityEngine;

namespace CodeBase.AbilityDecorator.Stats
{
    [Serializable]
    public class JetPackAbilityStats 
    {
        public int Level = 0;
        public int MaxLevel = 1;
        public bool IsBuy = false;
        public int TimeActive  = 0;
        public int Price  = 800;
        public AbilityType AbilityType = AbilityType.JetPack;
    }
}