using UnityEngine;
using System.Collections;

public class ctrlGame_specific : MonoBehaviour {

    private int score;
    private float timer;
    private float currentDifficulty;
    private float increaseDifficultyRatio;
    private float increaseDifficultyTime;
    private float initTime;
    private float currentTime;
    private Vector3 center;


    // Use this for initialization
    void Start () {
        Debug.Log("Start of ctrlGameData is called");
        score = 0;
        currentDifficulty = 1;
        increaseDifficultyRatio = 1.1f;
        increaseDifficultyTime = 2;
        initTime = Time.time;
        center = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        currentTime = Time.time;
	
	}
}
