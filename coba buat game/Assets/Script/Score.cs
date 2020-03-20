using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text Scoretext;
    float lasty=0, point = 0;
    int offset;


    void Update()
    {
        if (player.transform.position.y>lasty)
        {
            lasty = player.transform.position.y;
            offset = (int)lasty/ 5;
            point = offset*1000;
        }
        Scoretext.text = point.ToString();
    }
}
