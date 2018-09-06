using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_CharacterMovement : MonoBehaviour {

    bool IsWalking;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            if (Mathf.Round(Input.GetAxisRaw("LeftTrigger")) > 0 && Mathf.Round(Input.GetAxisRaw("RightTrigger")) > 0)
                IsWalking = false;
            else
                IsWalking = true;
        }

        else
            IsWalking = false;
    }


}
