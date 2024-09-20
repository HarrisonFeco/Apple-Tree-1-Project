using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APPLETREE : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;
    public float appleDropDelay = 0.5f;
    
    [Header("InscribedPoisonApple")]
    public GameObject poisonApplePrefab;
    public float PoisonAppleDropDelay = 1f; 
    int counter = 0;
    void Start()
    {
        Invoke("DropApples", 1f);
       
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = transform.position;
    }

    void DropPoisonApple()
    {
        GameObject poisonApple = Instantiate(poisonApplePrefab);
        poisonApple.transform.position = transform.position;
        
    }

   void DropApples()
   {    
        counter ++;
        if(counter %11 == 8)
        {
            Invoke("DropPoisonApple",PoisonAppleDropDelay);

        }
        else
        {
            Invoke("DropApple", appleDropDelay);
        }
        Invoke("DropApples", 1f);
   }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); 
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); 
        }
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }
}