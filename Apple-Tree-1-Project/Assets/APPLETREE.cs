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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed* Time.deltaTime;
        transform.position = pos;
    }
}
