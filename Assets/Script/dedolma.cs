using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedolma : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);


        if (collision.gameObject.tag == "Player")
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            timeManager.win = true;



        }
    }
    
}
