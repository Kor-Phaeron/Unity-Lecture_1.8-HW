using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAddSub : MonoBehaviour
{
    public Vector3 Vector_1;
    public Vector3 Vector_2;
    //public float ResultLength;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawVector(transform.position, Vector_1);
        Gizmos.color = Color.magenta;
        DrawVector(transform.position, Vector_2);
        Gizmos.color = Color.green;
        DrawVector(transform.position, Vector_1 + Vector_2);
        Gizmos.color = Color.blue;
        DrawVector(transform.position + Vector_2, Vector_1 - Vector_2);
    }

    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, 0.25f);


    }
}
