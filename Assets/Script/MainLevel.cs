using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cookiesText;
    [SerializeField] TextMeshProUGUI MoneyText;
    private void Update()
    {
        cookiesText.text = "COOKIE " + Score.cookies;
        MoneyText.text =  Score.Money + "$";


    }
}
