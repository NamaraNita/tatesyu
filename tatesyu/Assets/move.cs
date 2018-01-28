using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float speed;
    float size = 256;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, speed);
		
        if(this.transform.position.z+size<0)
        {
            this.transform.Translate(0, 0, size);
        }

	}
}
