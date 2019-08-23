using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт для точек ориентирования куба
public class PointsPositions : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
