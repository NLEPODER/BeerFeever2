using UnityEngine;
using System.Collections;
using System;

public class inputManager : MonoBehaviour {

    private GameObject lastBeer = null;
    private int coef = 1;
    
    public void clickButtonTypeBeer(string inputType)
    {
        GameObject[] beerList = GameObject.FindGameObjectsWithTag("Tag_Beer");
        GameObject oldestBeer = null;
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
            oldestBeer.GetComponent<beer_specific>().animateFill(oldestBeer);
            if(lastBeer != null)
            {
                if (String.Compare(lastBeer.GetComponent<beer_specific>().getBeerType(), oldestBeer.GetComponent<beer_specific>().getBeerType()) == 0)
                {
                    this.coef = (this.coef) * (int)Math.Ceiling(oldestBeer.GetComponent<beer_specific>().getSpeed());                    
                }
                else
                {
                    this.coef = 1;
                }
            }
            this.lastBeer = oldestBeer;
            ctrlGame_specific.combosAnimation(this.lastBeer, beerList);
            ctrlGame_specific.incrementScore(this.coef);

        }
        else
        {
            ctrlGame_specific.loseGame();

        }
    }


    private bool beerTypeMatch(string inputType, string beerType)
    {
        bool test = String.Equals(inputType, beerType, StringComparison.Ordinal);
        return test;
    }
}
