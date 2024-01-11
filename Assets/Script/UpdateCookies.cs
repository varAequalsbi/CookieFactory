using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateCookies : MonoBehaviour
{
    [SerializeField] private Score score;

    public void UpdateCookiesText(TextMeshProUGUI text)
    {
        int cookies = Score.cookies;
        text.text = "";
        text.text = "You Have " +cookies+ " Cookies";
    }
}
