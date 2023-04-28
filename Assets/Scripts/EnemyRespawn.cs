using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject[] Enemies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Enemies[0].transform.position = new Vector3(-223.7102f, 10.40213f, 83.6624f);
            Enemies[1].transform.position = new Vector3(-121.3502f, 10.40213f, 83.6624f);
            Enemies[2].transform.position = new Vector3(-53.25023f, 10.40213f, 83.6624f);
            Enemies[3].transform.position = new Vector3(0.4497681f, 10.40213f, 83.6624f);
            Enemies[4].transform.position = new Vector3(111.5498f, 10.40213f, 83.6624f);
        }
    }
}