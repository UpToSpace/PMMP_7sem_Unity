using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case "Floor":
                {
                    Debug.Log("Hit the floor!!!");
                    break;
                }
            case "Wall1":
                {
                    Debug.Log("Hit the Wall1!!!");
                    break;
                }
            case "Wall2":
                {
                    Debug.Log("Hit the Wall2!!!");
                    break;
                }
            default:
                break;
        }
    }
}
