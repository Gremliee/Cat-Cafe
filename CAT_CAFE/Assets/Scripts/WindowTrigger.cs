using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigger : MonoBehaviour
{
    bool detected = false;

    [SerializeField] GameObject windowPosition;
    [SerializeField] GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detected == true && Input.GetKeyDown(KeyCode.Q))
        {
            item = GameObject.FindWithTag("Item");
            FindObjectOfType<YEetOrder>().OrderGOod(item.GetComponent<SpriteRenderer>().sprite);
            FindObjectOfType<PlayerPickUp>().isPickup = false;
            FindObjectOfType<Money>().outWindow = true;
            FindObjectOfType<CakeSpawn>().spawned = false;
            FindObjectOfType<Orders>().NewOrder();
            //Destroy(item);

        }
    }

    public void DestroyItem()
    {
        Destroy(item);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        detected = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        detected = false;
    }
}
