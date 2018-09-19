﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCart : MonoBehaviour {
    public GameObject ref1;
    public GameObject ref2;
    int dir = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
      
        if (collision.tag == "Character")
        {
            if (dir == 0)
            {
                this.transform.position += new Vector3(0, -.1f, 0);
                collision.transform.position += new Vector3(0, -.1f, 0);
                if (this.transform.position.y <= ref2.transform.position.y) {
                    dir++;
                }
            }
            else if (dir == 2)
            {
                this.transform.position += new Vector3(0, .1f, 0);
                collision.transform.position += new Vector3(0, .1f, 0);
                if (this.transform.position.y >= ref1.transform.position.y)
                {
                    dir++;

                }
            }
            else if (dir == 1)
            {
                this.transform.position += new Vector3(.1f, 0, 0);
                collision.transform.position += new Vector3(.1f, 0, 0);
                if (this.transform.position.x >= ref1.transform.position.x)
                {
                    dir++;

                }
            }
            else if (dir == 3)
            {
                this.transform.position -= new Vector3(.1f, 0, 0);
                collision.transform.position -= new Vector3(.1f, 0, 0);
                if (this.transform.position.x <= ref2.transform.position.x)
                {
                    dir = 0;

                }
            }

        }
        
        
    }
}
