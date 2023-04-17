using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    [SerializeField] public bool isTrigger = false;
    public bool isPickup = false;
    Vector3 PlayerPosition;
    Vector2 ItemFinalPosition;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && isPickup == false)
        {
            isTrigger = true;
            Debug.Log("das no good");

        } 

        // run  a public function from the player script to tell player they are holding something
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTrigger = false;
    }

    private void Update()
    {
        if (isTrigger = true && Input.GetKeyDown(KeyCode.E))
        {
            isPickup = true;

        }
        if (isPickup == true)
        {
            GetComponent<Collider2D>().enabled = false;
            gameObject.transform.position = ItemFinalPosition;
            PlayerPosition = GameObject.FindWithTag("Player").transform.position;
            ItemFinalPosition = new Vector2(PlayerPosition.x + xOffset, PlayerPosition.y + yOffset);
            FindObjectOfType<PlayerMovement>().PickedUp();
        }
    }

    public void NoPickUp()
    {
        isPickup = false;
        Debug.Log("das");
    }


}
