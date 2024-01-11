using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHeader : MonoBehaviour
{
    [SerializeField] GameObject shopPanel;
    [SerializeField] GameObject currentPanel;

    public void HeaderShop()
    {
        currentPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
}
