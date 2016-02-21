﻿using UnityEngine;
using System.Collections;

public class checkCollision : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D (Collider2D Beer)
    {
        Beer.GetComponent<beer_specific>().setIsEnter(true);
    }

    void OnTriggerExit2D (Collider2D Beer)
    {
        if (Beer.GetComponent<beer_specific>().getFilled())
        {
            Destroy(Beer.gameObject);
        } else
        {
            Destroy(Beer.gameObject);
            ctrlGame_specific.loseGame();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
