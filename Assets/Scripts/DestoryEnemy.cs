using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour
{
       


    private void OnColliderEnter2D(Collider2D other)
    {
        if(other.tag == "Fireball")
        {
            Debug.Log("123");
            //Destroy(gameObject);
            
        }
        
        
    }
}