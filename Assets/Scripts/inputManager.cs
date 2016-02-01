using UnityEngine;
using System.Collections;
using System;

public class inputManager : MonoBehaviour {

    public void clickButtonTypeBeer(string inputType)
    {
        GameObject[] beerList = GameObject.FindGameObjectsWithTag("Tag_Beer");
        GameObject oldestBeer = null; ;
        foreach (GameObject beer in beerList)
        {
            if (!beer.GetComponent<beer_specific>().getFilled())
            {
                if (!oldestBeer && beerTypeMatch(inputType, beer.GetComponent<beer_specific>().getBeerType()))
                {
                    oldestBeer = beer;
                } else
                {
                    if(beer.GetComponent<beer_specific>().getCreateTime() < oldestBeer.GetComponent<beer_specific>().getCreateTime() && beerTypeMatch(inputType, beer.GetComponent<beer_specific>().getBeerType()))
                    {
                        oldestBeer = beer;
                    }
                }
            }
        }
        if (oldestBeer)
        {
            Destroy(oldestBeer);
        }
        else
        {
            //lose Game
        }
    }


    private bool beerTypeMatch(string inputType, string beerType)
    {
        bool test = String.Equals(inputType, beerType, StringComparison.Ordinal);
        if (test)
        {
            Debug.Log("MATHCHING");
        } else
        {
            Debug.Log(inputType + " != " + beerType);
        }
        return test;
    }
}
