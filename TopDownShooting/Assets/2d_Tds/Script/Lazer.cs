using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

    private LineRenderer LazerRender;
    //public Transform LazerHit;
    private float timecounter;

	// Use this for initialization
	void Start () {
        LazerRender = GetComponent<LineRenderer>();
        timecounter = 1;
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        if (hit.transform.tag == "Character")
        {
            Tds_Character Char = hit.transform.gameObject.GetComponent<Tds_Character>();
            if (Char.IsAlive && timecounter >= 1)
            {
                Char.ApplyDamage(1);
                timecounter = 0;
            }
            timecounter += Time.deltaTime;
        }
        else
        {
            timecounter = 1;
        }
        LazerRender.SetPosition(0, transform.position);
        LazerRender.SetPosition(1, hit.point);
	}
}
