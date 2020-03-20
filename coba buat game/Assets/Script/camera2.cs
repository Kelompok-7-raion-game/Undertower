using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public Transform playerTransform;
    public float smoothspeed, lasty;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = playerTransform.position;
        target.z = transform.position.z;
        target.x = transform.position.x;
        if(playerTransform.position.y > 2.92 && playerTransform.position.y > lasty && !gameover.endgame) {
            transform.position = Vector3.MoveTowards(transform.position, target, smoothspeed);
            lasty = playerTransform.position.y;
        }
        
    }
}
