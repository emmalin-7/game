using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Scales;

public class DisplayCard : MonoBehaviour
{
    [field: SerializeField] public SpellCard spellcardData {get;set;}
    [field: SerializeField] public CharCard chcardData {get;set;}

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
        nameText.text = chcardData.cardName;
        healthText.text = chcardData.health.ToString();

        // Will display range of damage (Functional string?) e.g. 6-8
        damageText.text = $"{chcardData.damageMin} - {chcardData.damageMax}";
        
    }

}
