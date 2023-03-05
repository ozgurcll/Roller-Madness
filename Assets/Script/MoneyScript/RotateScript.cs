using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] Vector3 angle;

    private void Update()
    {
        transform.Rotate(angle, Space.World);
    }

}
