using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScene : ScenesController
{
    public GameObject pausePanel;

    void Start(){
        //ads
    }

    public void pause(){
        Time.timeScale=0;
        pausePanel.SetActive(true);

        //ads
    }

    public void resume(){
        Time.timeScale=1;
        pausePanel.SetActive(false);
    }

    public void nextLevel(){
        openScene(Application.loadedLevel+1);
    }

    public void restart(){
        openScene(Application.loadedLevel);
    }
}
