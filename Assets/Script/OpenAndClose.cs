using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakingOpenClose : MonoBehaviour
{
    public void open(GameObject name)
    {
        name.SetActive(true);
    }

    public void close(GameObject name)
    {
        name.SetActive(false);
    }


}
