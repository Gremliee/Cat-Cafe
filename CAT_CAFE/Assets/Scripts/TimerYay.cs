using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerYay : MonoBehaviour
{
    [SerializeField] int startingTime = 180;

    [SerializeField] bool isZero = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = startingTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isZero == false) 
        {
            StartCoroutine(TimeToDie());

        }

        if(startingTime <= 0)
        {
            Debug.Log("Timer no");
            isZero = true;
            FindObjectOfType<Game>().WaitAndLoad(); 
        }
    }

    private IEnumerator TimeToDie()
    {
        yield return new WaitForSeconds(1);

        GetComponent<TextMeshProUGUI>().text = startingTime.ToString();

    }
}
