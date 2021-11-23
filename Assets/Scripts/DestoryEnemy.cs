using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour
{
    private bool hit;
        private BoxCollider2D enemyCollider;

    private void Awake()
    {
        enemyCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if(hit) return;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Fireball")
        {
            return;
        }
        
        void OnDisable()
        {
            Destroy(GameObject.FindWithTag("Enemy"));
        }
        hit = true;
        enemyCollider.enabled = false;
        Destroy(GameObject.FindWithTag("Enemy"));
    }
}