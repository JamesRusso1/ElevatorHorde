using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSwitch : MonoBehaviour
{
    public BoxCollider mainCollider;
    public GameObject mainPlayer;
    public Animator mainPlayerAnimator;

    void Start()
    {
        GetRagdollBits();
        ragDollOff();
    }

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            ragDollOn();
        }
    }

    Collider[] ragDollColliders;
    Rigidbody[] limbsRigidBody;

    void GetRagdollBits()
    {
        ragDollColliders = mainPlayer.GetComponentsInChildren<Collider>();
        limbsRigidBody = mainPlayer.GetComponentsInChildren<Rigidbody>();
    }

    void ragDollOn()
    {
        mainPlayerAnimator.enabled = false;

        foreach (Collider col in ragDollColliders)
        {
            col.enabled = true;
        }
        foreach (Rigidbody rigid in limbsRigidBody)
        {
            rigid.isKinematic = false;
        }


        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void ragDollOff()
    {
        foreach (Collider col in ragDollColliders)
        {
            col.enabled = false;
        }
        foreach (Rigidbody rigid in limbsRigidBody)
        {
            rigid.isKinematic = true;
        }

        mainPlayerAnimator.enabled = true;
        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}