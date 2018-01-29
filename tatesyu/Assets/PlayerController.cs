using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int move = 20;
    private int nowPosition = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        if (StateManager.stateManaager.state != 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("end");
                Application.Quit();
            }
            return;
        }
        if (nowPosition != -1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-move, 0, 0);
            nowPosition -= 1;
        }

        if (nowPosition != 1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(move, 0, 0);
            nowPosition += 1;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Goal")
        {
            GameOver();
        }
        else {
            GameClear();
        }
        StateManager.stateManaager.DrawResult();
    }

    void GameOver() {
        StateManager.stateManaager.state = 2;
    }
    void GameClear() {
        StateManager.stateManaager.state = 1;
    }
}
