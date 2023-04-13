using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackLevel2 : MonoBehaviour
{
    [SerializeField] NavMeshAgent[] Enemies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Enemies[0].enabled = true;
            Enemies[1].enabled = true;
            Enemies[2].enabled = true;
            Enemies[3].enabled = true;
            Enemies[4].enabled = true;
            Enemies[5].enabled = true;
            Enemies[6].enabled = true;
            Enemies[7].enabled = true;
            Enemies[8].enabled = true;
        }
    }
}