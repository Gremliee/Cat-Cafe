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

    // Update is called once per frame
    void Update()
    {
        //If detected = true, and the key E is down
        if (detected == true && Input.GetKeyDown(KeyCode.E))
        {
            item = GameObject.FindWithTag("Item");
            item.transform.position = counterPosition.transform.position;
            FindObjectOfType<PlayerPickUp>().NoPickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        detected = true;
    }

    public GameObject CounterPosition()
    {
        return counterPosition;
    }
    //a public function that returns position of counter
}
