using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float movementSpeed = 3f;
    public float detectionRadius = 10f;
    public float attackDistance = 2f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        float angle = Vector3.Angle(directionToPlayer, transform.forward);

        if (angle < 90f)
        {
            if (directionToPlayer.magnitude > attackDistance)
            {
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
                Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);

                transform.rotation = Quaternion.Slerp(transform.rotation, rotationToPlayer, Time.deltaTime * movementSpeed);
            }
        }
    }
}
