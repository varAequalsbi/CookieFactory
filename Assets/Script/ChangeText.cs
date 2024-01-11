using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Score Score;
    public void flourTextUpdate(TextMeshProUGUI text)
    {
        int flour = Score.Flour;
        text.text = "";
        text.text = "QTY: " + flour;
    }
    public void eggTextUpdate(TextMeshProUGUI text)
    {
        int egg = Score.Egg;
        text.text = "";
        text.text = "QTY: " + egg;
    }
    public void butterTextUpdate(TextMeshProUGUI text)
    {
        int butter = Score.Butter;
        text.text = "";
        text.text = "QTY: " + butter;
    }
}
