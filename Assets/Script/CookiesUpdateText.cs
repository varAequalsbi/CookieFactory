using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CookiesUpdateText : MonoBehaviour
{
    [SerializeField] private Score score;
    public void CookiesTextUpdate(TextMeshProUGUI text)
    {
        int cookies = Score.cookies;
        text.text = "";
        text.text = "COOKIE " + Score.cookies;
    }
}
