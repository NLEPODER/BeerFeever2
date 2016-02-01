using UnityEngine;
using System.Collections;

public class beer_specific : MonoBehaviour
{
    private string beerType;
    private string beerColor;
    private bool filled;
    private float speed;
    private float createTime;
    private bool isEnter;

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
    public bool getFilled()
    {
        return this.filled;
    }
    public void setCreateTime(float createTime)
    {
        this.createTime = createTime;
    }
    public float getCreateTime()
    {
        return this.createTime;
    }
    public void setIsEnter(bool isEnter)
    {
        this.isEnter = isEnter;
    }
    public bool getIsEnter()
    {
        return this.isEnter;
    }


}
