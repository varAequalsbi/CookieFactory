using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;

public class SellController : MonoBehaviour
{
    [SerializeField] private int Price = 102;
    public int total = 1;
    public void getinput(string inpt)
    {
        
        try { 
            int intinpt = int.Parse(inpt);
            total = intinpt;
        }catch(Exception ex)
        {
            int intinpt = 1;
            total = intinpt;
        }
        Debug.Log(total);
    }

    public void PriceUpdate(TextMeshProUGUI text)
    {
        text.text = string.Empty;
        int price = total * Price;
        text.text = "Sell for " + price + "$";
    }

    public void Sell()
    {
        if (Score.cookies >= total)
        {
            if (Score.cookies >= 0)
            {
                Debug.Log("insufficient cookies!");
            }
            Score.cookies = Score.cookies - 1;
            if (total == 0)
            {
                total = 1;
            } 
            int gain = total * 102;

            Score.Money = Score.Money + gain;
        }
        else
        {
            Debug.Log("insufficient cookies!!");
        }
    }

    public void SellALL(Score score)
    {
        int gain = Score.cookies * Price;    
        Score.cookies = 0;
        Score.Money = Score.Money + gain;
    }
}
