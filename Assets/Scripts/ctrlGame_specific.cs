using UnityEngine;
using System.Collections;

public class ctrlGame_specific : MonoBehaviour {

    private int score;
    private Vector3 center;


    // Use this for initialization
    void Start () {
        Debug.Log("Start of ctrlGameData is called");
        score = 0;
        center = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
