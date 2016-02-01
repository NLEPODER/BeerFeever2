using UnityEngine;
using System.Collections;

public class inputManager : MonoBehaviour {

    public void clickButtonTypeBeer(string beerType)
    {
        GameObject[] beerList = GameObject.FindGameObjectsWithTag("Tag_Beer");
        GameObject oldestBeer = null; ;
        foreach (GameObject beer in beerList)
        {
            if (!beer.GetComponent<beer_specific>().getFilled())
            {
                if (!oldestBeer)
                {
                    oldestBeer = beer;
                } else
                {
                    if(beer.GetComponent<beer_specific>().getCreateTime() < oldestBeer.GetComponent<beer_specific>().getCreateTime())
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
    }
}
