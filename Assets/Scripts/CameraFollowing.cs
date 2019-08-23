using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = Vector3.zero;
        if (player.position.y <= 0) //Камера не поднимается за кубом при прыжке, а при падении с дороги следует за ним
            targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z);
        else
            targetPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);
        gameObject.transform.position = Vector3.MoveTowards(transform.position , targetPosition, 4.0f * Time.deltaTime);
    }
}
