using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    public GameObject Door;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = Door.GetComponent<Rigidbody>();
    }

    public void moveDoor()
    {
        Vector3 newRotation = new Vector3(0, 10, 0);
        transform.eulerAngles = newRotation;
    }
}