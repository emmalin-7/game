using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scales
{
    public class Card : ScriptableObject
    {
        [field: SerializeField] public string CardName { get; set; }

        [field: SerializeField] private Sprite CardSprite;

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
            Defbuff
        }

        public enum AttributeTarget
        {
            health,
            damage,
            priorityTarget,
        }
    }
}