using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IncDecShop : MonoBehaviour
{
    public int qtyFlower = 1;
    public int qtyEgg = 1;
    public int qtyButter = 1;

    public void incrementFlower(TextMeshProUGUI text)
    {
        qtyFlower = qtyFlower+1;
        text.text = qtyFlower.ToString();
    }
    public void incrementEgg(TextMeshProUGUI text)
    {
        qtyEgg = qtyEgg + 1;
        text.text = qtyEgg.ToString();
    }
    public void incrementButter(TextMeshProUGUI text)
    {
        qtyButter = qtyButter + 1;
        text.text = qtyButter.ToString();
    }

    public void decrementFlower(TextMeshProUGUI text)
    {
        if (qtyFlower > 1)
        {
            qtyFlower = qtyFlower - 1;
        }
        text.text = qtyFlower.ToString();
    }
    public void decrementEgg(TextMeshProUGUI text)
    {
        if (qtyEgg > 1) { 
        qtyEgg = qtyEgg - 1;
        }
        text.text = qtyEgg.ToString();
    }
    public void decrementButter(TextMeshProUGUI text)
    {
        if (qtyButter > 1)
        {
        qtyButter = qtyButter - 1;
        }
        text.text = qtyButter.ToString();
    }
}
