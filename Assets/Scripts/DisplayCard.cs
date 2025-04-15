using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Scales;
using System.Security.Cryptography;

public class DisplayCard : MonoBehaviour
{
    // Universal card vars
    public Card cardData;

    [field: SerializeField] public Image cardImage {get;set;}
    [field: SerializeField] public TMP_Text nameText {get;set;}
    [field: SerializeField] public Image displayImage {get;set;}

    [field: SerializeField] public Sprite[] cardImageTypes {get;set;}


    // CharCard vars
    [field: SerializeField] public TMP_Text healthText {get;set;}
    [field: SerializeField] public TMP_Text damageText {get;set;}

    // SpellCard vars
    [field: SerializeField] public TMP_Text descriptionText {get;set;}
    [field: SerializeField] public GameObject userSymbol {get;set;}
    [field: SerializeField] public TMP_Text attributeChangeAmount {get;set;}



    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        // Universal Card Changes

        nameText.text = cardData.cardName;
        displayImage.sprite = cardData.cardSprite;
     
        // Runs appropriate updater
        if (cardData is CharCard characterCard){
            UpdateCharCardDisplay(characterCard);
        } else if (cardData is SpellCard spellCard){
            UpdateSpellCardDisplay(spellCard);
        }

    }

    private void UpdateCharCardDisplay(CharCard characterCard){

        // Will display range of damage (Functional string?) e.g. 6-8
        healthText.text = characterCard.health.ToString();
        damageText.text = $"{characterCard.damageMin} - {characterCard.damageMax}";
        if (characterCard.cardType == Card.CardType.Ally){
            cardImage.sprite = cardImageTypes[0];
        } else if (characterCard.cardType == Card.CardType.Enemy){
            cardImage.sprite = cardImageTypes[1];
        }

    }

    private void UpdateSpellCardDisplay(SpellCard spellCard){
        cardImage.sprite = cardImageTypes[2];
        attributeChangeAmount.text = spellCard.attributeChangeAmount.ToString();
    }



}
