using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    public float dropSpeed = -0.03f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, this.dropSpeed);
        if(transform.position.z<-100.0f)
        {
            Destroy(gameObject);
        }
		
	}
}
