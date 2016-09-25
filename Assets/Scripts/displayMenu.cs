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
        if (PlayerPrefs.HasKey("Score"))
        {
            mScore.text = "Last Score : " + PlayerPrefs.GetInt("Score");
        }
        else
        {
            mScore.text = "Last Score : 0" ;
        }
        if(PlayerPrefs.HasKey("HighScore"))
        {
            mHighScore.text = "Highscore : " + PlayerPrefs.GetInt("HighScore");

        } else
        {
            mHighScore.text = "Highscore : 0";
        }
    }
}
