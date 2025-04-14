using System.Runtime.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace Scales
{
    public class SpellEffectApplier
    {
        public static void ApplySpell(SpellCard spell, CharCardStats targetStats)
        {
            // Checking through list of attribute changes for the spell
            for (int i = 0; i < spell.attributeTarget.Count;i++)
            {

                ApplyEffectToAttribute(spell,spell.spellType,spell.attributeTarget[i], spell.attributeChangeAmount[i],targetStats);
            }
        }

        // Helper function for ApplySpell
        private static void ApplyEffectToAttribute(SpellCard spell, Card.SpellType spellType, Card.AttributeTarget attributeTarget, int changeAmount, CharCardStats targetStats)
        {
            if (spellType == Card.SpellType.Damage || spellType == Card.SpellType.Debuff )
            {
                // Reduce health/damage if Debuff and reduces health if damage
                changeAmount = -changeAmount;
            }
            
            switch (attributeTarget)
            {
                // Applies change to targetStats
                case Card.AttributeTarget.health:
                    targetStats.health += changeAmount;
                    break;
                case Card.AttributeTarget.damage:
                    targetStats.damageMax += changeAmount;
                    targetStats.damageMin += changeAmount;
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("Attribute not implimented");
                    break;
            }

            LimitCheck(targetStats);
        }

            private static void LimitCheck(CharCardStats stats)
            {
                // Makes sure stats changes are logical
                stats.health = Mathf.Max(stats.health, 0);
                stats.damageMax = Mathf.Max(stats.damageMax, stats.damageMin);
                stats.damageMin = Mathf.Max(stats.damageMin, 0);
            }

    }
}