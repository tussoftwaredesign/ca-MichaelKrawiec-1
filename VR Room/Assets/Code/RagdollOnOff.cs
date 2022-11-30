using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RagdollOnOff : MonoBehaviour
{
    public BoxCollider mainCollider;
    public GameObject rig;
    public Animator animator;
    public Rigidbody rb;

    public EnemyFollow Follow;
    public NavMeshAgent NavMA;
    public AudioSource Audio;

    void Start()
    {
        GetRagdollBits();
        ragdollOff();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sword")
        {
            ragdollOn();
            Debug.Log("RagdollOn");
        }
    }

    public Collider[] ragdollColliders;
    Rigidbody[] limbsRigidbodies;
    void GetRagdollBits()
    {
        ragdollColliders = rig.GetComponentsInChildren<Collider>();
        limbsRigidbodies = rig.GetComponentsInChildren<Rigidbody>();
    }

    void ragdollOn()
    {
        animator.enabled = false;
        Follow.enabled = false;
        NavMA.enabled = false;
        Audio.enabled = false;

        foreach (Collider col in ragdollColliders)
        {
            col.enabled = true;
        }

        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = false;
        }

        
        mainCollider.enabled = false;
        rb.isKinematic = true;
    }

    void ragdollOff()
    {
        foreach (Collider col in ragdollColliders) {
            col.enabled = false;
        }

        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = true;
        }

        Follow.enabled = true;
        Audio.enabled = true;
        NavMA.enabled = true;
        animator.enabled = true;
        mainCollider.enabled = true;
        rb.isKinematic = false;
    }
}
