using UnityEngine;
using System.Collections;

public class ctrlGame_specific : MonoBehaviour {

    private static int score;
    private Vector3 center;


    // Use this for initialization
    void Start () {
        score = 0;
        center = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void incrementScore()
    {
        score++;
        Debug.Log("Score : " + score);
    }

    private static int getScore()
    {
        return score;
    }

    public static void loseGame()
    {
        Debug.Log("Perdu ! Score Final : " + score);
    }
}
