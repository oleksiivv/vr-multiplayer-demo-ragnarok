using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyController : MonoBehaviour
{
    public GameObject[] panels;


    void Start(){
        if(PlayerPrefs.GetInt("studied",-1)==-1){
            show(0);
        }
        else{
            hideAll();
        }
    }


    public void complete(){
        hideAll();
        PlayerPrefs.SetInt("studied",1);
    }

    public void show(int id){
        hideAll();
        panels[id].SetActive(true);
    }
    public void hideAll(){
        foreach(var panel in panels)panel.SetActive(false);
    }
}
