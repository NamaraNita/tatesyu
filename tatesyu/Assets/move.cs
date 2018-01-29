using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    float speed;
    float size = 256;

	// Use this for initialization
	void Start () {
        speed = StateManager.stateManaager.speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (StateManager.stateManaager.state != 0)
        {
            return;
        }
        transform.Translate(0, 0, speed);
		
        if(this.transform.position.z+size<0)
        {
            this.transform.Translate(0, 0, size);
        }

	}
}
