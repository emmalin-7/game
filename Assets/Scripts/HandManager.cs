using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Scales;
using UnityEngine.AI;
using System.Runtime.InteropServices;

public class HandManager : MonoBehaviour
{
    [field: SerializeField] public DeckManager deckManager;
    [field: SerializeField] public GameObject cardPrefab;  // Assign card prefab in inspector

    [field: SerializeField] public Transform handTransform; // Root of the hand positions

    [field: SerializeField] public float fanSpread = 7.5f;

    [field: SerializeField] public List<GameObject> cardsInHand = new List<GameObject>(); // Hold a list of card objects in our hand
    
    [field: SerializeField] public float cardSpacing = 100f;

    [field: SerializeField] public float verticalSpacing = 100f;
    void Start() 
    {
      
    }

    public void AddCardToHand(SpellCard cardData)
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsInHand.Add(newCard);

        newCard.GetComponent<DisplayCard>().cardData = cardData;

        UpdateHandVisuals();
    }

    void Update() {
        UpdateHandVisuals();
    }

    private void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;

        if (cardCount == 1) {
            cardsInHand[0].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            cardsInHand[0].transform.localPosition = new Vector3(0f, 0f, 0f);
            return;


        }

        for (int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

            float horizontalOffset = (cardSpacing * (i - (cardCount - 1) / 2f));

            float normalizedPosition = (2f * i / (cardCount - 1) - 1f);
            float verticalOffset = verticalSpacing * (1 - normalizedPosition * normalizedPosition);            
            cardsInHand[i].transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0f);
        }
    }
}

