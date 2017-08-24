using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Text scoreText;
    public Text winText;
    public int score = 0;

    // Use this for initialization
	void Start () {
        GameManager.instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE : " + score;
        Win();
	}

    void Win()
    {
        if (score >= 8) winText.text = "You Win!!";
    }
}
