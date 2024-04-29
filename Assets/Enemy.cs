using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed=1;

    void Start(){
        transform.localScale*=Random.Range(1.0f,2.0f);
        
        speed/=5;
    }

    void Update(){
        transform.Translate(Vector3.forward/5*speed*Time.timeScale*1.4f*PlayerPrefs.GetFloat("quality",1f));

        if(PlayerCollisions.win && transform.eulerAngles.y!=90){
            transform.eulerAngles=new Vector3(0,90,0);
        }
    }
    
    public void OnPointerEnter()
    {
        //speed=-1;
        transform.eulerAngles=new Vector3(0,90,0);
        //OnPointerExit();
        //Destroy(gameObject);
    }
    
    public void OnPointerExit()
    {
        //
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag=="Enemy"){
            var tmp=other.gameObject.GetComponent<Enemy>().speed;

            other.gameObject.GetComponent<Enemy>().speed=speed;

            speed=tmp;
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Coin"){
            Destroy(other.gameObject);
        }
    }



}
