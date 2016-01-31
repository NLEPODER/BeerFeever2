using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour {

    public void toMenu()
    {
        SceneManager.LoadScene("sMenu");
    }
    public void toGame()
    {
        SceneManager.LoadScene("sGame");
    }
    public void toOptions()
    {
        SceneManager.LoadScene("sOptions");
    }
}
