using UnityEngine;
using System.Collections;

public class beerGenerator_specific : MonoBehaviour
{
    private string beerGeneratorColor;

    // Use this for initialization
    void Start()
    {
        Transform TranformLine = this.gameObject.GetComponent(typeof(Transform)) as Transform;
        switch (TranformLine.position.y.ToString())
        {
            case "-8.5":
                beerGeneratorColor = "blonde";
                break;
            case "-1.1":
                beerGeneratorColor = "brune";
                break;
            case "5.3":
                beerGeneratorColor = "rousse";
                break;
            default:
                break;
        }
    }

    void Update()
    {
    }

    public string getBeerGeneratorColor()
    {
        return beerGeneratorColor;
    }


}
