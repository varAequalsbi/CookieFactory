using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeTextMoney : MonoBehaviour
{
    [SerializeField] private Score score;
    public void MoneyTextUpdate(TextMeshProUGUI text)
    {
        int money = Score.Money;
        text.text = "";
        text.text = text.text + Score.Money + "$";
    }

    
}
