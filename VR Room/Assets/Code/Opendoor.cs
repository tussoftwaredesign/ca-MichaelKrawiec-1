
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


    public void moveWall()
    {
        rb.velocity = new Vector3(1, 1, 2);

    }
}