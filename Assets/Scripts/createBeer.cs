using UnityEngine;
using System.Collections;

public class createBeer : MonoBehaviour {

    private GameObject beerPrefab;
    private string beerColor;

    // Use this for initialization
    void Start () {
        beerPrefab = Resources.Load("Prefabs/BeerPrefab", typeof(GameObject)) as GameObject;
        beerColor = gameObject.GetComponent<beerGenerator_specific>().getBeerGeneratorColor();
    }
	
	// Update is called once per frame
	void Update () {
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
                        gameObject_beer = initialisationBeer("boot");
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
        gameObject_beer.GetComponent<beer_specific>().setBeerColor(beerColor);
        gameObject_beer.GetComponent<beer_specific>().setFilled(false);
        return gameObject_beer;
    }

    private bool beerGeneratorIsReady()
    {
        if (gameObject.GetComponent<beerGenerator_specific>().getBeerGeneratorColor().GetType() == typeof(string))
        {
            return true;
        } else
        {
            Debug.Log("BeerGenerator not reday yet");
            return false;
        }
    }
}
