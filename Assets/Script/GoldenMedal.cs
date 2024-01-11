using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenMedal : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] GameObject goldenmedal;
    [SerializeField] private int requirement = 100;


    private void Update()
    {
        GottenGoldenMedal(goldenmedal);
    }


    private void GottenGoldenMedal(GameObject goldenMedal)
    {
        if (Score.cookies >= requirement)
        {
            goldenMedal.SetActive(true);
        }
    }
}
