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
                if (!oldestBeer)
                {
                    if(beerTypeMatch(inputType, beer.GetComponent<beer_specific>().getBeerType()) && beer.GetComponent<beer_specific>().getIsEnter())
                    {
                        oldestBeer = beer;
                    }
                } else
                {
                    if((beer.GetComponent<beer_specific>().getCreateTime() < oldestBeer.GetComponent<beer_specific>().getCreateTime()) && beerTypeMatch(inputType, beer.GetComponent<beer_specific>().getBeerType()) && beer.GetComponent<beer_specific>().getIsEnter())
                    {
                        oldestBeer = beer;
                    }
                }
            }
        }
        if (oldestBeer)
        {
            oldestBeer.GetComponent<beer_specific>().setFilled(true);
            oldestBeer.GetComponent<beer_specific>().animateFill();
        }
        else
        {
            Debug.Log("PERDU");
            //lose Game
        }
    }


    private bool beerTypeMatch(string inputType, string beerType)
    {
        bool test = String.Equals(inputType, beerType, StringComparison.Ordinal);
        return test;
    }
}
