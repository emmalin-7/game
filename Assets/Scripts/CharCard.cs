using System.Collections.Generic;
using UnityEngine;
using Scales;

[CreateAssetMenu(fileName = "New Char Card", menuName = "CharCard")]
public class CharCard : Card
{


    [field: SerializeField] public int health { get; set; }

    // These may be replaced by a spell system
    [field: SerializeField] public int damageMin { set; get; }
    [field: SerializeField] public int damageMax { set; get; }

    [field: SerializeField] public Card.PriorityTarget priorityTarget { set; get; }

    [field: SerializeField] public Card.CardType cardType { set; get; }


    // Potentially impliment damage/card types here

}


