using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

namespace Scales{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card: ScriptableObject
    {
        [field: SerializeField] public string CardName {get;private set;}
        
        [field: SerializeField] public int Health {get;set;}

        [field: SerializeField] public Sprite CardSprite {get;private set;}


        // These may be replaced by a spell system
        [field: SerializeField] public int DamageMin {set;get;}
        [field: SerializeField] public int DamageMax {set;get;}

        // Potentially impliment damage/card types here


    }




}
