using UnityEngine;
using System.Collections;

public class createBeer : MonoBehaviour {

    private GameObject beerPrefab;
    private string beerColor;
    private float initTime;
    private float oldTime;
    private float currentTime;


    // Use this for initialization
    void Start () {
        beerPrefab = Resources.Load("Prefabs/BeerPrefab", typeof(GameObject)) as GameObject;
        beerColor = gameObject.GetComponent<beerGenerator_specific>().getBeerGeneratorColor();
        initTime = Time.time;
        oldTime = Time.time;

    }

    // Update is called once per frame
    void Update () {
        currentTime = Time.time;
        if (beerGeneratorIsReady())
        {
            int rand = Random.Range(0, 4);
            if (rand != 0)
            {
                GameObject gameObject_beer;
                switch (rand)
                {
                    case 1:
                        gameObject_beer = initialisationBeer("demi");
                        break;
                    case 2:
                        gameObject_beer = initialisationBeer("pinte");
                        break;
                    case 3:
                        gameObject_beer = initialisationBeer("botte");
                        break;
                    default:
                        break;
                }
            }
        }     
    }

    private GameObject initialisationBeer(string beerType)
    {
        string firstChar = beerType[0].ToString();
        string isBeerType = "is" + firstChar.ToUpper() + beerType.Substring(1);
        GameObject gameObject_beer = Instantiate(beerPrefab, this.transform.position, Quaternion.identity) as GameObject;
        Animator animator;
        animator = gameObject_beer.GetComponent<Animator>();
        animator.SetBool(isBeerType, true);
        gameObject_beer.GetComponent<beer_specific>().setBeerType(beerType);
        gameObject_beer.GetComponent<beer_specific>().setIsEnter(false);
        gameObject_beer.GetComponent<beer_specific>().setCreateTime(currentTime);
        gameObject_beer.GetComponent<beer_specific>().setBeerColor(beerColor);
        gameObject_beer.GetComponent<beer_specific>().setFilled(false);
        gameObject_beer.GetComponent<beer_specific>().setSpeed(beerSpeed());
        return gameObject_beer;
    }

    private bool beerGeneratorIsReady()
    {
        if (gameObject.GetComponent<beerGenerator_specific>().getBeerGeneratorColor().GetType() == typeof(string))
        {
            return delay(); ;
        } else
        {
            return false;
        }
    }
    private bool delay()
    {
        float deltaTime = currentTime - oldTime;
        if (deltaTime > timeBetweenTwoBeers()) 
        {
            oldTime = currentTime;
            return true;
        }
        else
        {
            return false;
        }
    }

    private float timeBetweenTwoBeers()
    {
        float coef = 2f;
        float retour = coef / beerSpeed();
        return retour;
    }

    private float beerSpeed()
    {
        float a = 0.01f;
        float b = 2f;
        float retour = a * (currentTime - initTime)+ b;
        return retour;

    }
}
