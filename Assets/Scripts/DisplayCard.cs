using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Scales;

public class DisplayCard : MonoBehaviour
{
    [field: SerializeField] public CharCard cardData {get;set;}
    [field: SerializeField] public Image cardImage {get;set;}
    [field: SerializeField] public TMP_Text nameText {get;set;}
    [field: SerializeField] public TMP_Text healthText {get;set;}
    [field: SerializeField] public TMP_Text damageText {get;set;}
    [field: SerializeField] public Image[] typeImages {get;set;}


    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        nameText.text = cardData.CardName;
        healthText.text = cardData.Health.ToString();

        // Will display range of damage (Functional string?) e.g. 6-8
        damageText.text = $"{cardData.DamageMin} - {cardData.DamageMax}";
        
    }

}
