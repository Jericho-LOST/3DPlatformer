using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWayPointIndex = 0;

    [SerializeField] float speed = 1.0f;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) > .1f) ;
        
      
        {

        }

    }
 
    Transform.position //aparently using speed instead of delta is too quick 
    
}
