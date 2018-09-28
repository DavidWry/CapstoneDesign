using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inithe : MonoBehaviour {
    public float a = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, a); ;
        a = a - .01f;


    }
}
