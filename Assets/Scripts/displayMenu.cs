using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayMenu : MonoBehaviour {

    [SerializeField]
    private Text mScore;
    [SerializeField]
    private Text mHighScore;

    void Update()
    {
        mScore.text = "Last Score : " + PlayerPrefs.GetInt("Score");
        mHighScore.text = "Highscore : " + PlayerPrefs.GetInt("HighScore");
        Debug.Log("text = " +mScore.text);
    }
}
