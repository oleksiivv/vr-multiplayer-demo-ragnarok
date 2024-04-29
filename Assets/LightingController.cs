using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingController : MonoBehaviour
{
    public GameObject lighting;

    public PlayerSoundEffects sound;

    public void setState(bool state){
        lighting.SetActive(state);

        if(state){
            sound.playThunder();
        }
        else{
            sound.stopThunder();
        }
    }
}
