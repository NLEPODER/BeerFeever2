using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ctrlGame_specific : MonoBehaviour {

    private static int score;
    public static int highScore;
    public Text tScore;
    public Text tHighsScore;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        UpdateScore();
    }

    // Affichage du nouveau score
    void UpdateScore ()
    {
        tScore = GameObject.Find("Score").GetComponent<Text>();
        tScore.text = "Score : " +score;
        tScore = GameObject.Find("HighScore").GetComponent<Text>();
        tScore.text = "Highscore : " + highScore;
    }

    // Update is called once per frame
    void Update () {
        UpdateScore();
	}

    public static void incrementScore()
    {
        score++;
        if (score > highScore)
        {
            highScore = score;
        }
    }

    private static int getScore()
    {
        return score;
    }

    public static void loseGame()
    {
        Debug.Log("Perdu ! Score Final : " + score);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("HighScore", highScore);
        SceneManager.LoadScene("sMenu");
    }
}
