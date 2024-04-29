using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0,2)==1){
            transform.position=new Vector3(transform.position.x,8,transform.position.z);
        }
        if(transform.position.y<-8)transform.position+=new Vector3(0,1,0);
    }

}
