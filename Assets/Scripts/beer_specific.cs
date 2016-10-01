using UnityEngine;
using System.Collections;

public class beer_specific : MonoBehaviour
{
    private string beerType;
    private bool combosInProgress;
    private string beerColor;
    private bool filled;
    private float speed;
    private float createTime;
    private bool isEnter;
    public AudioSource fillBeer;
    public GameObject halo;
    private Color color_1;

    // Use this for initialization
    void Start()
    {

        color_1 = new Color32(255, 225, 0, 255);
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (this.combosInProgress)
        {
            this.changeHalo(.5f, color_1);
         }
        else
        {
            this.changeHalo(0.0f, color_1);
        }
    }

    public void changeHalo(float intensity,  Color color)
    {
        halo.GetComponent<Light>().color = color;
        halo.GetComponent<Light>().intensity = intensity;
    }

    public void animateFill (GameObject obj)
    {
        Animator animator;
        animator = obj.GetComponent<Animator>();
        animator.SetBool("is" + ToTitleCase(beerType) + ToTitleCase(beerColor), true);
        fillBeer.Play();        
    }

    public void setCombosInProgress(bool b)
    {
        this.combosInProgress = b;
    }

    private string ToTitleCase(string stringToConvert)
    {
        string firstChar = stringToConvert[0].ToString();
        return (stringToConvert.Length > 0 ? firstChar.ToUpper() + stringToConvert.Substring(1) : stringToConvert);
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }
    public float getSpeed()
    {
        return speed;
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
