using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD_Enemy : MonoBehaviour
{
    [SerializeField] public Text enemyCount;
    [SerializeField] GameObject[] enemies;
    public bool pause = false;

    
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            pause = !pause;
        }
        if (!pause){
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); //Sahnedeki tüm "Enemy" tagli gameobjectleri dizi olarak alıyor
        enemyCount.text = "Enemy: " + enemies.Length.ToString();

        if(enemies.Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
    }
}
