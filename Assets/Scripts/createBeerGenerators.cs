using UnityEngine;
using System.Collections;

public class createBeerGenerators : MonoBehaviour
{

    public static GameObject BeerGeneratorPrefab = Resources.Load("Prefabs/BeerGeneratorPrefab", typeof(GameObject)) as GameObject;

    public static int speed;


    // Use this for initialization
    void Start()
    {

        Vector3 posTop = new Vector3(0, 5.3f, 0);
        Vector3 posMid = new Vector3(0, -1.1f, 0);
        Vector3 posBottom = new Vector3(0, -8.5f, 0);
     
        instantiateBeerGenerator(posTop);
        instantiateBeerGenerator(posMid);
        instantiateBeerGenerator(posBottom);

    }

    void instantiateBeerGenerator(Vector3 pos)
    {
        GameObject BeerGenerator;
        BeerGenerator = Instantiate(createBeerGenerators.BeerGeneratorPrefab, pos, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
