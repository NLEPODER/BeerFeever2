using UnityEngine;
using System.Collections;

public class beerGenerator_specific : MonoBehaviour
{
    private string beerGeneratorColor;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
    }

    public string getBeerGeneratorColor()
    {
        return beerGeneratorColor;
    }

    public void setBeerGeneratorColor(string beerGeneratorColor)
    {
        this.beerGeneratorColor = beerGeneratorColor;
    }


}
