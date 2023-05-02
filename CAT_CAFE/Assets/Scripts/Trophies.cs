using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophies : MonoBehaviour
{
    [SerializeField] List<Sprite> medals;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<Money>().currentMoney >= 10 && FindObjectOfType<Money>().currentMoney < 100)
        {
            GetComponent<SpriteRenderer>().sprite = medals[0];
        }
        if (FindObjectOfType<Money>().currentMoney >= 100 && FindObjectOfType<Money>().currentMoney < 130)
        {
            GetComponent<SpriteRenderer>().sprite = medals[1];
        }
        if (FindObjectOfType<Money>().currentMoney >= 130 && FindObjectOfType<Money>().currentMoney < 150)
        {
            GetComponent<SpriteRenderer>().sprite = medals[2];
        }
        if (FindObjectOfType<Money>().currentMoney >= 150)
        {
            GetComponent<SpriteRenderer>().sprite = medals[3];
        }
    }
}
