using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject[] redCubes = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (var redCube in redCubes)
            {
                Destroy(redCube);
            }
        }
    }
}
