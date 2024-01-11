using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakingController : MonoBehaviour
{
    [SerializeField] private int FlourReq = 1;
    [SerializeField] private int EggReq = 1;
    [SerializeField] private int ButterReq = 1;
    [SerializeField] private int CookiesGain= 1;

    public void Bake(Score score)
    {
        int butter = Score.Butter;
        int flour = Score.Flour;
        int egg = Score.Egg;

        if (butter > 0 && flour > 0 && egg > 0)
        {
            Score.Butter = Score.Butter - ButterReq;
            Score.Flour = Score.Flour - FlourReq;
            Score.Egg = Score.Egg - EggReq;
            Score.cookies = Score.cookies + CookiesGain;
            Debug.Log("you just baked an cookie!  " + Score.cookies);
        }
        else
        {
            Debug.Log("insufficient ingridients");
        }
    }
}
