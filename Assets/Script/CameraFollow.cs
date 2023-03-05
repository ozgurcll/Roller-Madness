using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform top;

    Vector3 offsetVector;
    float camspeed = 5f;

    void Start()
    {
        offsetVector = CalcOffset(top);
    }

    void FixedUpdate()
    {
        FollowCam();
    }

    private Vector3 CalcOffset(Transform newTarget)
    {
        return transform.position - newTarget.position;
    }
    

    

    private void FollowCam()
    {
        if (top != null)
        {
            Vector3 camfollow = offsetVector + top.position;
            transform.position = Vector3.Lerp(transform.position, camfollow, camspeed * Time.deltaTime);
            transform.LookAt(top.transform.position);
        }
        
    }
}
