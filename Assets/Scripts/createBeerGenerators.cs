using UnityEngine;
using System.Collections;

public class createBeerGenerators : MonoBehaviour
{

    private GameObject BeerGeneratorPrefab;

    // Use this for initialization
    void Start()
    {
        BeerGeneratorPrefab = Resources.Load("Prefabs/BeerGeneratorPrefab", typeof(GameObject)) as GameObject;
        Vector3 posTop = new Vector3(-4f, 2.3f, 0);
        Vector3 posMid = new Vector3(-4f, 0.65f, 0);
        Vector3 posBottom = new Vector3(-4f, -1.1f, 0);
     
        instantiateBeerGenerator(posTop, "brune");
        instantiateBeerGenerator(posMid, "rousse");
        instantiateBeerGenerator(posBottom, "blonde");

    }

    void instantiateBeerGenerator(Vector3 pos, string beerGeneratorColor)
    {
        GameObject BeerGenerator;
        BeerGenerator = Instantiate(BeerGeneratorPrefab, pos, Quaternion.identity) as GameObject;
        BeerGenerator.GetComponent<beerGenerator_specific>().setBeerGeneratorColor(beerGeneratorColor);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
