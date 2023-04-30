using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    Money gameStatus;
    int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        gameStatus = FindObjectOfType<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = gameStatus.currentMoney;
        GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
    }
}
