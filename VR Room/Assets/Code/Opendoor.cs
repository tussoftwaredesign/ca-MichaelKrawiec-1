using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    public GameObject Toilet;

    public GameObject Door;
    public Rigidbody rb;
    public Animator animator;

    bool allInActive = true;
    public GameObject[] myObjects;
    // Start is called before the first frame update
    void Start()
    {
        rb = Door.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    public void check()
    {
        for (int i = 0; i < myObjects.Length; i++)
        {
            if (!myObjects[i].activeSelf)
            {
                allInActive = true;
                break; //this "quits" the for loop, you don't need to check the rest of the items if you already found one that's active
            }
        }

        if (allInActive)
        Toilet.GetComponent<Animator>().enabled = false;
        moveDoor();
    }


    public void moveDoor()
    {
        
        Vector3 newRotation = new Vector3(0, -85, 0);
        transform.eulerAngles = newRotation;
        Debug.Log("Opening Door!");
    }
}