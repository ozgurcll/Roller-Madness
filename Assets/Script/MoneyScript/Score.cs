using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public int money;

    public int currentMoney;


    private void Update()
    {
        currentMoney = money;
    }
}
