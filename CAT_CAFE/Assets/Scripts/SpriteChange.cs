using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField] Sprite newItem;
    public bool isChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create a function that can be called from CounterTrig
            //Inside of function, run line that will change sprite
            //Call a function FROM CounterTrig to get Sprite

    public void ItemChange(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;

        isChanged = true;
    }    
}
