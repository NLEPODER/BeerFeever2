using UnityEngine;
using System.Collections;

public class beer_specific : MonoBehaviour
{
    private string beerType;
    private string beerColor;
    private bool filled;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
         transform.Translate(3 * 1 * Time.deltaTime, 0, 0);
    }

    public void setBeerType(string beerType)
    {
        this.beerType = beerType;
    }
    public void setBeerColor(string beerColor)
    {
        this.beerColor = beerColor;
    }
    public void setFilled(bool filled)
    {
        this.filled = filled;
    }

}
