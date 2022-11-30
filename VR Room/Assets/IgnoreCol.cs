using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCol : MonoBehaviour
{
    public CharacterController collider;
    public Collider objectsignore;
    public Collider m1;
    public Collider m2;
    public Collider m3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(objectsignore, collider);

        Physics.IgnoreCollision(m1, collider);
        Physics.IgnoreCollision(m2, collider);
        Physics.IgnoreCollision(m3, collider);
    }
}
