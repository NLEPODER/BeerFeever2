using UnityEngine;
using System.Collections;

public class beerGenerator_specific : MonoBehaviour
{
    private string beerGeneratorColor;

    // Use this for initialization
    void Start()
    {
        beerGeneratorColor = "blonde";
    }

    void Update()
    {
         //transform.Translate(Game_controller.getSpeedBeer() * 1 * Time.deltaTime, 0, 0);
    }

    public string getBeerGeneratorColor()
    {
        return beerGeneratorColor;
    }


}
