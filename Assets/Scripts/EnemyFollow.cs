using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target; // creating variable for the trtet object (in this case the player)
    //is transform the class we use to get an open input in the inspector

 
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, target.position, 10*Time.deltaTime);
    }
}
