using System.Collections.Generic;
using UnityEngine;
using Scales;

public class CharCardStats : MonoBehaviour
{
    public CharCard charCardStartData;

    public string cardName;
    public int health;
    public int damageMin;
    public int damageMax;
    public Card.PriorityTarget priorityTarget;

    private bool statsSet = false;

    void Update()
    {
        if (!statsSet && charCardStartData != null){
            SetStartStats();
        }
    }

    private void SetStartStats(){
        cardName = charCardStartData.cardName;
        health = charCardStartData.health;
        damageMin = charCardStartData.damageMin;
        damageMax = charCardStartData.damageMax;
        priorityTarget = charCardStartData.priorityTarget;
    }

}
