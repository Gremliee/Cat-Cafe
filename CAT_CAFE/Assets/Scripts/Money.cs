using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Money : MonoBehaviour
{
    public bool outWindow = false;
    [SerializeField] public int currentMoney = 0;
    [SerializeField] TextMeshProUGUI text;
    
    // Start is called before the first frame update

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType<Money>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (outWindow == true)
        {
            Debug.Log("yeet");
            
            outWindow = false;
            FindObjectOfType<WindowTrigger>().DestroyItem();
        }

    }

    public void AddMoney()
    {
        currentMoney += FindObjectOfType<PlayerPickUp>().GetCost();
    }

    public int GetScore()
    {
        return currentMoney;
    }
}
