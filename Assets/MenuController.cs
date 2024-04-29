using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject map;

    public ScenesController scenes;

    public void setMapState(bool active){
        map.SetActive(active);
    }

    void Start(){
        showActiveLevels();
    }


    public GameObject[] lockers;

    public void openLevel(int id){
        if(!lockers[id].activeSelf){
            scenes.openScene(id+3);
        }
    }


    public void showActiveLevels(){
        lockers[0].SetActive(false);
        for(int i=1;i<lockers.Length;i++){
            if(PlayerPrefs.GetInt("levelCompleted"+i.ToString(),-1)==1){
                lockers[i].SetActive(false);
                lockers[i-1].SetActive(false);
            }
            else{
                lockers[i].SetActive(true);
                lockers[i-1].SetActive(true);
            }
        }
        lockers[0].SetActive(false);
    }
}
