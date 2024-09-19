using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundDisplay : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;
    private Text roundText;

    void Start()
    {
        roundText = GetComponent<Text>();
    }

    void Update()
    {
        roundText.text = round.ToString("#,0");
    }
}
