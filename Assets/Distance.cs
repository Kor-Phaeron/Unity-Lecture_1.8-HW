using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform object_1;
    public Transform object_2;

    private void FixedUpdate()
    {
        getDistance();
    }
    void getDistance()
    {
        float dist = Vector3.Distance(object_1.position, object_2.position);
        Debug.Log("Distance between selected objects: " + dist);
    }
}
