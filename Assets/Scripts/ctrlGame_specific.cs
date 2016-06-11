using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ctrlGame_specific : MonoBehaviour {

    private static int score;
    public Text tScore;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        UpdateScore();
    }

    // Affichage du nouveau score
    void UpdateScore ()
    {
        tScore = GameObject.Find("Score").GetComponent<Text>();
        tScore.text = "Score : " +score;
    }

    // Update is called once per frame
    void Update () {
        UpdateScore();
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
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene("sMenu");
    }
}
