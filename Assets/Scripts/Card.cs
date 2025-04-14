using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

public class Card : ScriptableObject
{
    [field: SerializeField] public string CardName {get;set;}

    [field: SerializeField] private Sprite CardSprite;
}
