using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeSpawn : MonoBehaviour
{
    public bool spawned = false;

    [SerializeField] GameObject spawnerPosition;
    [SerializeField] GameObject cake;
    [SerializeField] GameObject counterTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == false)
        {
            spawned = true;
            GameObject cakeYay = Instantiate(cake, spawnerPosition.transform.position, transform.rotation);
            FindObjectOfType<CounterTrig>().isChanged = false;
            counterTrigger.GetComponent<CounterTrig>().AddToItemVariable(cakeYay);
        }
    }
}
