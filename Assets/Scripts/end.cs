using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
       public void endgame()
   {
       SceneManager.LoadScene("Level1");
   }
        public void BackToMenu()
   {
       SceneManager.LoadScene(0);
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
