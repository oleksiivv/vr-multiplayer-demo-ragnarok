using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndpointController : MonoBehaviour
{
    public GameObject[] deathPanel;

    public PlayerCollisions player;

    public PlayerSoundEffects sound;


    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Enemy" && !deathPanel[0].activeSelf){
            player.death();

            sound.playDeath();

            foreach(var detail in deathPanel)detail.SetActive(true);
        }
    }
}
