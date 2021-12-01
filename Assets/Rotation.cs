using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int AxisNumber; // Axis x = 0; axis y = 1; axis z = 2; all axes = 3; no rotation = every else
    [SerializeField]
    private float _rotationVelocity = 90.0f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (AxisNumber == 0)
        {
            transform.Rotate(new Vector3(_rotationVelocity, 0, 0) * Time.deltaTime);
        }
        else if (AxisNumber == 1)
        {
            transform.Rotate(new Vector3(0, _rotationVelocity, 0) * Time.deltaTime);
        }
        else if (AxisNumber == 2)
        {
            transform.Rotate(new Vector3(0, 0, _rotationVelocity) * Time.deltaTime);
        }
        else if (AxisNumber == 3)
        {
            transform.Rotate(new Vector3(_rotationVelocity, _rotationVelocity, _rotationVelocity) * Time.deltaTime);
        }
        else
        {

        }
    }
}
