using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public bool right = true;

    void Update()
    {
        MoveCube();
    }

    void MoveCube()
    {
        if (right)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            print(other.tag);
            right = !right;
        }
    }
}