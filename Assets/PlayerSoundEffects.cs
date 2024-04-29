using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    public AudioSource source;

    public AudioClip thunder, coinGet, death, enemyDeath, winEffect;


    public void playThunder(){
        if(source.clip==thunder)return;
        source.volume=1;
        
        source.enabled=false;
        source.clip=thunder;
        source.enabled=PlayerPrefs.GetInt("!sound")==0;

        source.Play();
    }

    public void stopThunder(){
        StartCoroutine(stopLightning());
    }

    public void playCoinGet(){
        source.volume=1;

        source.enabled=false;
        source.clip=coinGet;
        source.enabled=PlayerPrefs.GetInt("!sound")==0;

        source.Play();
    }
    public void playDeath(){
        source.volume=1;

        source.enabled=false;
        source.clip=death;
        source.enabled=PlayerPrefs.GetInt("!sound")==0;

        source.Play();
    }
    public void playDeathEnemy(){
        source.volume=1;

        source.enabled=false;
        source.clip=enemyDeath;
        source.enabled=PlayerPrefs.GetInt("!sound")==0;

        source.Play();
    }

    public void playWin(){
        source.volume=1;

        source.enabled=false;
        source.clip=winEffect;
        source.enabled=PlayerPrefs.GetInt("!sound")==0;

        source.Play();
    }

    IEnumerator stopLightning(){
        while(source.volume>0){
            source.volume-=0.01f;
            yield return new WaitForSeconds(0.01f);
        }
        source.clip=null;
        source.enabled=false;
    }
}
