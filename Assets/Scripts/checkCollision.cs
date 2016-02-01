using UnityEngine;
using System.Collections;

public class checkCollision : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D (Collider2D Beer)
    {
        time = this.GetComponent<timeCounter>().seconds;
        Beer.GetComponent<beer_specific>().setEnterTime(time);
        Debug.Log(time + Beer.GetComponent<beer_specific>().getBeerType() + Beer.GetComponent<beer_specific>().getBeerColor());
    }

    void OnTriggerExite2D (Collider2D Beer)
    {
        Debug.Log("Bam");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
