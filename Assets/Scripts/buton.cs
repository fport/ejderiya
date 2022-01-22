using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class buton : MonoBehaviour
{
    public GameObject buton1;
     public GameObject buton2;

    public bool pause=false;
    public void buton1_click()
    {
        pause=true;
    }

     
    private void Update(){
    if (Input.GetKeyDown(KeyCode.P)){
            pause = !pause;
        }  
    
  if (pause){
  
   
  buton1.gameObject.SetActive(false);
    buton2.gameObject.SetActive(false);
     
     
    }
    if(!pause){
     
   buton1.gameObject.SetActive(true);
    buton2.gameObject.SetActive(true);
     }
    }
}
