using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public GameObject[] coin;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Enemy"){
            other.gameObject.transform.GetChild(0).transform.gameObject.GetComponent<ParticleSystem>().Play();
            other.gameObject.transform.GetChild(0).transform.parent=null;

            if(Random.Range(0,2)==1){
                int n=Random.Range(0,coin.Length);
                Instantiate(coin[n], new Vector3(other.gameObject.transform.position.x,other.gameObject.transform.position.y+0.5f,-0.44f), coin[n].transform.rotation);
            }
            Destroy(other.gameObject);
        }
    }
}
