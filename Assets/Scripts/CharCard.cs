using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

namespace Scales{
    [CreateAssetMenu(fileName = "New Char Card", menuName = "CharCard")]
    public class CharCard: ScriptableObject
    {
        [field: SerializeField] public string CardName {get;set;}
        
        [field: SerializeField] public int Health {get;set;}

        [field: SerializeField] private Sprite CardSprite;


        // These may be replaced by a spell system
        [field: SerializeField] public int DamageMin {set;get;}
        [field: SerializeField] public int DamageMax {set;get;}

        // Potentially impliment damage/card types here


    }

}
