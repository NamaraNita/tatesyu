using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour {

    public GameObject Capsulep;
    public GameObject Cubep;
    public GameObject Goal;
    float span = 1f;
    float delta = 0;
    int ratio = 2;
    float distance = 245;
    int generateCount = 0;

    float[] array = new float[] { 235, 245, 255};
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate() {

        if (StateManager.stateManaager.state != 0)
        {
            return;
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span && generateCount <= 10)
        {
            this.delta = 0;
            GameObject item;

            if (generateCount < 10)
            {
                int dice = Random.Range(1, 11);
                if (dice <= this.ratio)
                {
                    item = Instantiate(Capsulep) as GameObject;
                }
                else
                {
                    item = Instantiate(Cubep) as GameObject;
                }
                int xRandom = Random.Range(0, 3);
                float x = array[xRandom];

                item.transform.position = new Vector3(x, 1, 100);
                generateCount++;
            }
            else{
                item = Instantiate(Goal) as GameObject;
                item.transform.position = new Vector3(245, 1, 100);

            }
        }
    }
		
}
