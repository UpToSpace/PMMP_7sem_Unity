using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float raycastDistance = 10f;
    public LayerMask targetLayer;
    public GameObject target;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(moveHorizontal, 0, moveVertical) * Time.deltaTime * 5f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootRaycast();
        }
    }

    void ShootRaycast()
    {
        Ray ray = new Ray(transform.position, Vector3.forward);
        Debug.DrawRay(transform.position, Vector3.forward * 100f, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                GameObject enemy = hit.collider.gameObject;
                if (enemy != null)
                {
                    Destroy(enemy);
                }
            }
        }
    }
}
