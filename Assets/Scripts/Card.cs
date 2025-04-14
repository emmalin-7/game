using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scales
{
    public class Card : ScriptableObject
    {
        [field: SerializeField] public string cardName { get; set; }

        [field: SerializeField] private Sprite cardSprite;

        [field: SerializeField] public AnimationClip animationClip;

        public enum AttackType
        {
            Single,
            Multi
        }

        public enum PriorityTarget
        {
            MostHealth,
            MostDamage,
            LeastCurrentHealth
        }

        public enum SpellType
        {
            Damage,
            Buff,
            Debuff
        }

        public enum AttributeTarget
        {
            health,
            damage
        }
    }
}