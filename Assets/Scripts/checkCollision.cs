using UnityEngine;
using System.Collections;

public class checkCollision : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D (Collider2D Beer)
    {
        time = this.GetComponent<timeCounterCollision>().seconds;
        Beer.GetComponent<beer_specific>().setEnterTime(time);
        Debug.Log(time + Beer.GetComponent<beer_specific>().getBeerType() + Beer.GetComponent<beer_specific>().getBeerColor());
    }

    void OnTriggerExit2D (Collider2D Beer)
    {
        Destroy(Beer.gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
