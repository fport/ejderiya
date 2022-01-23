using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
           public void restart()
   {
 
            SceneManager.LoadScene(1);

   }
       public void endgame()
   {
       if (SceneManager.GetActiveScene().buildIndex < 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(0);
        }
   }
        public void BackToMenu()
   {
       SceneManager.LoadScene(0);
   }
   
}
