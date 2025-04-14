using System.Collections.Generic;
using UnityEngine;
using Scales;

[CreateAssetMenu(fileName = "New Spell Card", menuName = "SpellCard")]
public class SpellCard : Card
{
    [field: SerializeField] public SpellType spellType { get; set;}
    [field: SerializeField] public List<int> attributeChangeAmount { get; }


}
