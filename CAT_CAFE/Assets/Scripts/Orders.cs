using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orders : MonoBehaviour
{
    [SerializeField] GameObject Dessert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewOrder()
    {
        Destroy(gameObject);
        yes();
        FindObjectOfType<OrderSpawn>().isOrder = false;
        Debug.Log("a");
    }

    IEnumerator yes()
    {
        yield return new WaitForSeconds(3);
    }
}
