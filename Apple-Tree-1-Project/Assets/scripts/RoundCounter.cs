using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 0;
    private Text roundCount;

    void Start()
    {
        roundCount = GetComponent<Text>();
    }
    void Update()
    {
        roundCount.text = "Round:" + round.ToString("#,0");
    }
}