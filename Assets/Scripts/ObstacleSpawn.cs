using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obstaclePrefabs;   //Префабы препятствий
    private float delay;            //Текущая задержка

    //Мин время respawn'а 
    public float minDelay;
    
    //Макс время respawn'а 
    public float maxDelay;
    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(minDelay, maxDelay);
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if(delay <= 0)
        {
            CreateObstacle();
            delay = Random.Range(minDelay, maxDelay);
        }
    }

    void CreateObstacle()
    {
        Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)], transform.position, transform.rotation);
    }
}
