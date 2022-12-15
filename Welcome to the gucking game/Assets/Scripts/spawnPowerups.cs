using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPowerups : MonoBehaviour
{
    public GameObject[] powerups;


    private float spawnPositionX=202.1f;
    private float spawnPositionZRange=12f;

    public float timer;
    private int delay=8;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        timer+=Time.deltaTime;
        

        if(timer>delay){
            int powerupsIndex=Random.Range(0,powerups.Length);
            Vector3 spawnPosition=new Vector3(spawnPositionX,Random.Range(.5f,7.2f),Random.Range(spawnPositionZRange,-spawnPositionZRange));
            Instantiate(powerups[powerupsIndex], spawnPosition, powerups[powerupsIndex].transform.rotation);
            timer=0;
        }
    }
}
