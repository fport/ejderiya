using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Enemy : MonoBehaviour
{
    [SerializeField] public Text enemyCount;
    [SerializeField] GameObject[] enemies;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); //Sahnedeki tüm "Enemy" tagli gameobjectleri dizi olarak alıyor
        enemyCount.text = "Enemy: " + enemies.Length.ToString();
    }
}
