using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour {

    public GameObject Capsulep;
    public GameObject Cubep;
    float span = 1.0f;
    float delta = 0;
    int ratio = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= this.ratio)
            {
                item = Instantiate(Capsulep) as GameObject;
            }else
            {
                item = Instantiate(Cubep) as GameObject;
            }
            float x = Random.Range(-1, 2);
            float y = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, y, 4);
            
        }
		
	}
}
