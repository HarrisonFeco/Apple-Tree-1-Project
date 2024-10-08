using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 4;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY*i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
        
    }
    void Update()
    {
        
    }
    public void AppleMissed()
        {
            GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
            foreach(GameObject tempGO in appleArray)
            {
                Destroy(tempGO);
            }

            int basketIndex = basketList.Count - 1;
            GameObject basketGO = basketList[basketIndex];
            basketList.RemoveAt(basketIndex);
            Destroy(basketGO);

            if(basketList.Count == 0)
            {
                RoundCounter.SET_NEW_ROUND_COUNT(RoundCounter.ROUND + 1);
                SceneManager.LoadScene("Game_Over");
            }
        }
    // public void PoisonApple()
    // {
    //     GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
    //     foreach(GameObject tempGO in appleArray)
    //     {
    //         Destroy(tempGO);
    //     }
    // }

}

