using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ѕолучаем все красные кубы и уничтожаем их
            GameObject[] redCubes = GameObject.FindGameObjectsWithTag("RedCube");
            foreach (var redCube in redCubes)
            {
                Destroy(redCube);
            }
        }
    }
}