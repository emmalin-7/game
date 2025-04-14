using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.AI;
using System.Runtime.InteropServices;
using Scales;


    public class DeckManager : MonoBehaviour
    {

        public List<SpellCard> allCards = new List<SpellCard>();

        private int currentIndex = 0;

    public void DrawCard(HandManager handManager)
        {
            if (allCards.Count == 0)
            return;

            SpellCard nextSpellCard = allCards[currentIndex];
            handManager.AddCardToHand(nextSpellCard);
            currentIndex = (currentIndex + 1) % allCards.Count;
        }

    }
