using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APPLETREE : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    public float speed =1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;
    public float appleDropDelay =1f;
   
    void Start()
    {
        Invoke("DropApple", 2f);  
        Invoke("DropPoisonApple",5f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }


    [Header("InscribedPoisonApple")]
    public GameObject poisonApplePre;    //problem 
    public float poisonAppleDropDelay = 9f;  

    void DropPoisonApple()            
    {
        GameObject poisonApple = Instantiate(poisonApplePre); //problem
        poisonApple.transform.position = transform.position;   //problem
        Invoke("DropPoisonApple", poisonAppleDropDelay);
       
    }

 
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed* Time.deltaTime;
        transform.position = pos;
        
        if(pos.x < -leftAndRightEdge) 
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {
        if(Random.value < changeDirChance)
        {
            speed *=-1;
        }
    }

}
