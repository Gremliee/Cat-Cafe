using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterTrig : MonoBehaviour
{
    bool detected = false;
    public bool isChanged = false;
    //Store counter position in a variable
    [SerializeField] GameObject counterPosition;
    [SerializeField] GameObject item;
    [SerializeField] Sprite toppings;

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
            FindObjectOfType<PlayerPickUp>().isPickup = false;

            if (item != null) 
            {             
                FindObjectOfType<PlayerPickUp>().NoPickUp();
                item.transform.position = counterPosition.transform.position;
                FindObjectOfType<PlayerPickUp>().isPickup = false;
                
               
                if (isChanged == false && tag != "RegularCounter")
                {
                    ChangeSprite(toppings);
                    isChanged = true;
                }   
                
            }
        }
        if (detected == true && Input.GetKeyDown(KeyCode.E) && item != null && FindObjectOfType<PlayerPickUp>().isPickup == false)
        {
            FindObjectOfType<PlayerPickUp>().isPickup = true;
            item = null;

        }

        if (isChanged == true && item == null)
        {
            ChangedIsChanged();
        }
        
    }

    public void ChangedIsChanged()
    {
        isChanged = false;
    }

    public GameObject CounterPosition()
    {
        return counterPosition;
    }
    //a public function that returns position of counter

    public Sprite Yeet()
    {
        return toppings;
    }

    private void ChangeSprite(Sprite sprite)
    {
        item.GetComponent<SpriteRenderer>().sprite = sprite;
        isChanged = true;
    }

    public void AddToItemVariable(GameObject itemThing)
    {
        item = itemThing;

    }


}
