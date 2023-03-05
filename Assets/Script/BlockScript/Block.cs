using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isColided;

    private void OnCollisionEnter(Collision collision)
    {
        if(isColided == false && collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(0.1f, 0.2f, 0.3f);
            
            isColided = true;
        }

    }
}
