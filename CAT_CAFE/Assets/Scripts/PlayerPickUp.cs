using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    [SerializeField] bool isTrigger = false;
    public bool isPickup = false;
    Vector3 PlayerPosition;
    Vector2 ItemFinalPosition;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    [SerializeField] int price = 10;
    [SerializeField] bool cri = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cri = true;
        // run  a public function from the player script to tell player they are holding something
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cri = false;
    }

    private void Update()
    {
        if (cri == true && Input.GetKeyDown(KeyCode.E) && isPickup == false)
        {
            isPickup = true;

        }
        if (isPickup == true )
        {
            GetComponent<Collider2D>().enabled = false;
            
            PlayerPosition = GameObject.FindWithTag("Player").transform.position;
            ItemFinalPosition = new Vector2(PlayerPosition.x + xOffset, PlayerPosition.y + yOffset);
            gameObject.transform.position = ItemFinalPosition;

        }
    }

    public void NoPickUp()
    {
        isPickup = false;
        Debug.Log("das");
    }

    public int GetCost()
    {
        return price;
    }
}
