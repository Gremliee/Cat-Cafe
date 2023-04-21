using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YEetOrder : MonoBehaviour
{
    [SerializeField] List<Sprite> itemOrder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OrderGOod (Sprite sprite)
    {
        if (sprite == (itemOrder[FindObjectOfType<OrderSpawn>().randomOrder]))
        {
            FindObjectOfType<Money>().AddMoney();
            Debug.Log("H");
        }
       
    }
}
