using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float speed;

    public float countdown=7;
    

    public int delay=3;
    public float delayTimer;

    public float timer;
    

    
    private int spawnPosX=-85;
    private float spawnRangeZ=10.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        int spawnRate=Random.Range(1,4);
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        delayTimer+=Time.deltaTime;
        timer+=Time.deltaTime;
        while(timer>countdown&&delayTimer>delay){
            
            //if(delayTimer>delay){
            Vector3 spawnPosition=new Vector3(spawnPosX,4,Random.Range(spawnRangeZ,-spawnRangeZ));
            Instantiate(obstaclePrefab,spawnPosition, obstaclePrefab.transform.rotation);
            delayTimer=0;
         //   }
       // }



        

        transform.Translate(Vector3.forward*Time.deltaTime*speed*-1);



       /* while(timer>countdown){
            if(interval>delay){
                speed+=5;
                interval=0;
            }
        }*/
        
        }
    }
}