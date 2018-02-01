using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    float dropSpeed;

	// Use this for initialization
	void Start ()
    {
        dropSpeed = StateManager.stateManaager.speed;

    }
	
	// Update is called once per frame
	void FixedUpdate() {
        if (StateManager.stateManaager.state != 0)
        {
            return;
        }
        transform.Translate(0, 0, this.dropSpeed);
        if(transform.position.z < -100.0f)
        {
            Destroy(gameObject);
        }
		
	}
}
