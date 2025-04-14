using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

namespace Scales{
    [CreateAssetMenu(fileName = "New Char Card", menuName = "CharCard")]
    public class CharCard: Card
    {
        
        
        [field: SerializeField] public int Health {get;set;}

        // These may be replaced by a spell system
        [field: SerializeField] public int DamageMin {set;get;}
        [field: SerializeField] public int DamageMax {set;get;}

        // Potentially impliment damage/card types here


    }

}
