using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    public GameManager gm;

    public void PlayButton()
    {

        Activate(false);
    }


    public void Activate(bool isActive = true)
    {
        
        if(isActive)
        {
            //called when game ends, panel turns back on
            //sound fx
        }
        else
        {
            gm.StartGame();
            //called when game starts, panel is turned off
            //sound fx, fx
        }
         gameObject.SetActive(isActive); 
    }

}
