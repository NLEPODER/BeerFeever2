using UnityEngine;
using System.Collections;

public class beer_specific : MonoBehaviour
{
    private string beerType;
    private string beerColor;
    private bool filled;
    private float speed;
    private float enterTime;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
         transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }
    public void setBeerType(string beerType)
    {
        this.beerType = beerType;
    }
    public string getBeerType()
    {
        return this.beerType;
    }
    public void setBeerColor(string beerColor)
    {
        this.beerColor = beerColor;
    }
    public string getBeerColor()
    {
        return this.beerColor;
    }
    public void setFilled(bool filled)
    {
        this.filled = filled;
    }
    public void setEnterTime(float entertime)
    {
        this.enterTime = enterTime;
    }
    public float getEnterTime()
    {
        return this.enterTime;
    }
}
