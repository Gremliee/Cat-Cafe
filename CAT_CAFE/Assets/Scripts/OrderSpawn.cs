using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrderSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> foodOrder;
    [SerializeField] GameObject waypoint;

    [SerializeField] public bool isOrder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Spawn();
    }

    private void Spawn()
    {
        if (isOrder == false)
        {
            
            GameObject fish = Instantiate(foodOrder[Random.Range(0, foodOrder.Count - 1)],
            waypoint.transform.position, transform.rotation);
            isOrder = true;
        }
    }

    
}
