﻿using UnityEngine;
using System.Collections;

public class inputManager : MonoBehaviour {

    public void clickButtonTypeBeer(string beerType)
    {
        GameObject[] beerList = GameObject.FindGameObjectsWithTag("Tag_Beer");
        foreach (GameObject beer in beerList)
        {
            Debug.Log("test");
        }
        Debug.Log(beerType);
    }
}
