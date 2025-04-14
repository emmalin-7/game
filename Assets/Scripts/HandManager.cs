using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Scales;

public class HandManager : MonoBehaviour
{
    [field: SerializeField] public GameObject cardPrefab;  // Assign card prefab in inspector

    [field: SerializeField] public Transform handTransform; // Root of the hand positions

    [field: SerializeField] public float fanSpread = 5f;

    [field: SerializeField] public List<GameObject> cardsInHand = new List<GameObject>(); // Hold a list of card objects in our hand


    void Start() 
    {
      AddCardToHand();
    }

   public void AddCardToHand() 
   {
      // Instantiate the card
   }


}
