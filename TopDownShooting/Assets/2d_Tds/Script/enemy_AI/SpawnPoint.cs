using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    private Vector2 startPos;

    public GameObject enemy;

    void Start()
    {
        startPos = transform.position;

        Spawn();
    }

    void Spawn()
    {
        GameObject clone = (GameObject)Instantiate(enemy, startPos, Quaternion.identity);
        clone.transform.parent = transform;

        Invoke("Spawn", 3.0f);
    }
}