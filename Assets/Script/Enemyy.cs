using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyy : MonoBehaviour
{
    public Transform target;
    public float speed = 6f;
    public float stopDistance = 1f;
    public GameObject effect;

   
    private void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    public void Update()
    {
        if(target != null)
        {
            transform.LookAt(target);
            float mesafe = Vector3.Distance(transform.position, target.position);
            if (mesafe >= stopDistance)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            timeManager.win = true;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.CompareTag("Object"))
        {
            Physics.IgnoreCollision(GetComponent<Collider>(), collision.collider, true);
        }
    }
    private void OnDisable()
    {
       // Instantiate(effect, transform.position, transform.rotation);
    }


    
}
