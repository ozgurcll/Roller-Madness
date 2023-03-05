using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pick : MonoBehaviour
{

    public Text scoretext;
    private void OnTriggerEnter(Collider other)
    {
        Score score = FindObjectOfType<Score>();
        score.money++;
        scoretext.text = "Money: " + score.money;

            Destroy(gameObject);
        

        

    }
    
}
