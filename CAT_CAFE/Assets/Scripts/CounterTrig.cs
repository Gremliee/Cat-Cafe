using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterTrig : MonoBehaviour
{
    bool detected = false;

    //Store counter position in a variable
    [SerializeField] GameObject counterPosition;
    [SerializeField] GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        detected = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        detected = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If detected = true, and the key Q is down
        if (detected == true && Input.GetKeyDown(KeyCode.Q) && FindObjectOfType<PlayerPickUp>().isPickup == true)
        {
            item = GameObject.FindWithTag("Item");
            FindObjectOfType<PlayerPickUp>().NoPickUp();
            item.transform.position = counterPosition.transform.position;
            FindObjectOfType<PlayerPickUp>().isPickup = false;
        }
        if (detected == true && FindObjectOfType<PlayerPickUp>().isPickup == false && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<PlayerPickUp>().isPickup = true;
        }
    }



    public GameObject CounterPosition()
    {
        return counterPosition;
    }
    //a public function that returns position of counter
}
