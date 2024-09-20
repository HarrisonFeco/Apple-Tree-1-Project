using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
     [Header("Dynamic")]
    static private Text _ROUND_TEXT;
    static private int _ROUND = 1;
    private Text txtCom;
    
    void Awake () 
    {
        _ROUND_TEXT = GetComponent<Text>();
        if(PlayerPrefs.HasKey("Round"))
        {
            ROUND = PlayerPrefs.GetInt("Round");
        }
        PlayerPrefs.SetInt("Round",ROUND);
    }

    static public int ROUND
    {
        get { return _ROUND; }
        private set 
        {
            _ROUND = value;
            PlayerPrefs.SetInt("Round",value);
            if (_ROUND_TEXT != null)
            {
                _ROUND_TEXT.text = "Round: " + value.ToString("#,0");
            }
        }
    }
static public void SET_NEW_ROUND_COUNT(int newRoundCount)
{
    ROUND = newRoundCount;
}

[Tooltip("Check this box to reset the Round in PlayerPrefs")]
public bool resetRoundCount = false;

void OnDrawGizmos()
{
    if(resetRoundCount)
    {
        resetRoundCount = false;
        PlayerPrefs.SetInt("Round",1);
        Debug.LogWarning("PlayerPrefs Round reset to 1.");
    }
}
}
