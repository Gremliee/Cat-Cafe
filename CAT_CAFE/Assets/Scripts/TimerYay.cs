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
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        if(currCountdownValue <= 0)
        {
            FindObjectOfType<Game>().LoadGameOver();
        }
    }

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 90)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            GetComponent<TextMeshProUGUI>().text = currCountdownValue.ToString();
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        Debug.Log("TIMES UP");
    }
}