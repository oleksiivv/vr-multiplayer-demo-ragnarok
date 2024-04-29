using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSController : MonoBehaviour
{
    public Text fpsText;
    // Start is called before the first frame update
    void Start()
    {
        
        if(PlayerPrefs.GetFloat("quality",2.5f)==2.5f){

            Application.targetFrameRate=30;
            Invoke(nameof(check),1f);

        }
        else{
            Application.targetFrameRate=30;
        }


        fpsText.gameObject.SetActive(false);
    }
    int fps;
    bool checkedVal=false;

    // Update is called once per frame
    void Update()
    {
        if(!checkedVal)fps=((int)(1f / Time.unscaledDeltaTime));

        //fpsText.text=fps.ToString();
    }


    void check(){
        int val=fps;

        if(val>=26){
            PlayerPrefs.SetFloat("quality",1);
            checkedVal=true;
            
        }
        else{
            Application.targetFrameRate=30;
        }
    }
}
