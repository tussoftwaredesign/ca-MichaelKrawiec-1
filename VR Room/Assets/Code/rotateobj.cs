using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobj : MonoBehaviour
{
    public float speed_x;
    public float speed_y;
    public float speed_z;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed_x, speed_y, speed_z * Time.deltaTime);
    }
}
