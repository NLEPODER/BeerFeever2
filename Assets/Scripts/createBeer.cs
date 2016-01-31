using UnityEngine;
using System.Collections;

public class createBeer : MonoBehaviour {

    private GameObject beerPrefab;

    // Use this for initialization
    void Start () {
        beerPrefab = Resources.Load("BeerPrefab", typeof(GameObject)) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {

        GameObject gameObject_beer =  Instantiate(beerPrefab, this.transform.position, Quaternion.identity) as GameObject;
        string beerType = null;
        Animator animator;
        switch (Random.Range(0, 4))
        {
            case 1:
                beerType = "demi";
                animator = gameObject_beer.GetComponent<Animator>();
                animator.SetBool("isDemi", true);
                break;
            case 2:
                beerType = "pinte";
                animator = gameObject_beer.GetComponent<Animator>();
                animator.SetBool("isPinte", true);
                break;
            case 3:
                beerType = "boot";
                animator = gameObject_beer.GetComponent<Animator>();
                animator.SetBool("isBoot", true);
                break;
        }
        /**gameObject_beer.GetComponent<beer_specific>().beerType = beerType;
        gameObject_beer.GetComponent<beer_specific>().beerColor = beerColor;
        gameObject_beer.GetComponent<beer_specific>().filled = false;

        gameObjectAllBeerList.Add(gameObject_beer);
        }
    */
    }
}
