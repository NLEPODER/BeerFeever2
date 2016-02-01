using UnityEngine;
using System.Collections;

public class checkCollision : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D (Collider2D Beer)
    {
        Beer.GetComponent<beer_specific>().setIsEnter(true);
        Debug.Log(Beer.GetComponent<beer_specific>().getIsEnter() +" "+ Beer.GetComponent<beer_specific>().getBeerType() +" "+ Beer.GetComponent<beer_specific>().getBeerColor());
    }

    void OnTriggerExit2D (Collider2D Beer)
    {
        Destroy(Beer.gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
