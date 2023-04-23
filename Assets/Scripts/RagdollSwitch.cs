using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RagdollSwitch : MonoBehaviour
{
    //This coding was provided by John Blanch
    public BoxCollider mainCollider;
    public GameObject mainPlayer;
    public Animator mainPlayerAnimator;
    public NavMeshAgent AI;

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
            AI.enabled = false;
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