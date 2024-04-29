using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private ParticleSystem sys;
    // Start is called before the first frame update
    void Start()
    {

        sys=gameObject.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();

        sys.Play();
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Coin"){
            Destroy(other.gameObject);
        }
    }

    
}
