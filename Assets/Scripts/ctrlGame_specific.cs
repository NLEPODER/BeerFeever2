using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ctrlGame_specific : MonoBehaviour {

    private static int score;
    private Vector3 center;


    // Use this for initialization
    void Start () {
        score = 0;
        center = new Vector3(0, 0, 0);

    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2-50, 25, 100, 50), "Score : "+score.ToString());
    }

    // Update is called once per frame
    void Update () {
	
	}

    public static void incrementScore()
    {
        score++;
    }

    private static int getScore()
    {
        return score;
    }

    public static void loseGame()
    {
        Debug.Log("Perdu ! Score Final : " + score);
        SceneManager.LoadScene("sMenu");
    }
}
