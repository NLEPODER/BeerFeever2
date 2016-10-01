using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class ctrlGame_specific : MonoBehaviour {

    private static int score;
    private static GameObject _lastBeer;
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

    public static void incrementScore(int coef)
    {
        score += coef;
        if (score > highScore)
        {
            highScore = score;
        }
    }

    public static void combosAnimation(GameObject lastBeer, GameObject[] beerList)
    {
        _lastBeer = lastBeer;
        foreach (GameObject beer in beerList)
        {
            // set combot animation
            bool b = String.Compare(lastBeer.GetComponent<beer_specific>().getBeerType(), beer.GetComponent<beer_specific>().getBeerType()) == 0;
            beer.GetComponent<beer_specific>().setCombosInProgress(b);

        }
    }

    private static int getScore()
    {
        return score;
    }


    public static GameObject getLastBeer()
    {
        return _lastBeer;
    }

    public static void loseGame()
    {
        Debug.Log("Perdu ! Score Final : " + score);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("HighScore", highScore);
        SceneManager.LoadScene("sMenu");
    }
}
