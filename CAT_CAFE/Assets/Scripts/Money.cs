using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    bool outWindow = false;
    [SerializeField] int currentMoney = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = currentMoney.ToString();
        if (outWindow == true)
        {
            Debug.Log("yeet");
            currentMoney =+FindObjectOfType<Food>().GetCost();
            outWindow = false;
            FindObjectOfType<WindowTrigger>().DestroyItem();
        }
    }

    public void YeetedOutWindow()
    {
        outWindow = true;
    }
}
