using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class transaction : MonoBehaviour
{
    //[SerializeField] IncDecShop IDS;
    [SerializeField] private Score score;

    [SerializeField] private int FlourPrice = 10;
    [SerializeField] private int EggPrice = 25;
    [SerializeField] private int ButterPrice = 39;

    public void FlourBuy(TextMeshProUGUI text)
    {
        int money = Score.Money;

        if (money >= 10)
        {
            Score.Money = money - 10;
            Score.Flour = Score.Flour + 1;
            text.text = text.text + 1;
            Debug.Log("money"+Score.Money);
            Debug.Log("Flour"+Score.Flour);

        }
    }

    public void EggBuy(TextMeshProUGUI text)
    {

        int money = Score.Money;

        if (money >= 25)
        {
            Score.Money = money - 25;
            Score.Egg = Score.Egg + 1;
            text.text = text.text + 1;
            Debug.Log("money" + Score.Money);
            Debug.Log("Egg" + Score.Egg);

        }
    }

    public void ButterBuy(TextMeshProUGUI text)
    {

        int money = Score.Money;

        if (money >= 39)
        {
            Score.Money = money - 39;
            Score.Butter = Score.Butter + 1;
            text.text = text.text + 1;
            Debug.Log("money" + Score.Money);
            Debug.Log("Butter" + Score.Butter);

        }
    }
}
