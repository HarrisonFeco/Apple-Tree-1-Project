using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    [Header("Dynamic")]
    private Text OverText;

    void Start()
    {
        OverText = GetComponent<Text>();
    }

    void Update()
    {
        
    }
}
