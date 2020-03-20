using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformrandom : MonoBehaviour
{
    public int currentpost=-1; //untuk ngecek bu
    public float kiri,tengah,kanan, miny, maxy;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void randomapos()
    {
        int index = Random.Range(0,3);
        if (index != currentpost)
        {
            currentpost = index;//current pos di inisialisasi dengan nilai random index
        }
        else
        {
            randomapos();//rekursif
        }
    }

    void spawn()
    {
        Vector2 SpawnPosition = Vector2.zero;//spawn position harus diinisiasi (dalam kasus ini 0,0)
        int i = 0;
        float lastheight = -3;
        while (i < 75)
        {
            randomapos();
            if (currentpost == 0)
            {
                SpawnPosition = new Vector2(kiri, Random.Range(miny, maxy)+lastheight);//Miny , Maxy untuk jarak antar platform 
            }
            else if(currentpost == 1)
            {
                SpawnPosition = new Vector2(tengah, Random.Range(miny, maxy) + lastheight);
            }
            else if (currentpost == 2)
            {
                SpawnPosition = new Vector2(kanan, Random.Range(miny, maxy) + lastheight);
            }
            lastheight = SpawnPosition.y;//untuk menyimpan nilai ketinggian 
            Instantiate(platform, SpawnPosition, Quaternion.identity);//untuk spawn platformnya 
            i++;
        }
    }


}
