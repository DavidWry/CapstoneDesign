using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {

    public Transform[] patrolingPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    public Transform target;
    public float chaseRange;
    public float approachRange;

    void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolingPoints[currentPatrolIndex];
    }

    void Update()
    {
        // Chasing Player AI

        // Distance between the player and the enemy
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if(distanceToTarget < chaseRange && distanceToTarget > approachRange)
        {
            // Start Chasing the player - Turn and move towards the target
            Vector3 targetDir = target.position - transform.position;
            float angle = Mathf.Atan2(-targetDir.x, targetDir.y) * Mathf.Rad2Deg;

            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
