using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour {
    public static StateManager stateManaager;
    public int state = 0; // 0 => play, 1 => Clear, 2 => gameover
    public int speed = -10;
    public Text result;
	// Use this for initialization
	void Awake () {
        stateManaager = this;
    }
    public void DrawResult()
    {
        result.text = state == 1 ? "Clear" : "GameOver";
    }
}
