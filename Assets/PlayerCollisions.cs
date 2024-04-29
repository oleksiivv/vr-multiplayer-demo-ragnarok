using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    public Slider gameTime;

    public float time=0.01f;

    public GameObject winPanel;

    public static bool win=false;

    public GameObject[] deathPanel;

    public Text coinsText;
    
    //public PlayerSoundEffects sound;

    void Start(){
        if(!gameTime)
        {
            gameTime = GameObject.Find("GameTime").GetComponent<Slider>();
        }
        
        gameTime.minValue=0;
        gameTime.maxValue=100;

        win=false;

        coinsText.text=PlayerPrefs.GetInt("coins").ToString();
        
        //ads banner
    }

    void Update(){

        if(gameTime.value==gameTime.maxValue && !winPanel.activeSelf){
            showWinPanel();
        }
        else{
            gameTime.value+=time*Time.timeScale;
        }
    }

    private bool showed=false;
    public void death(){
        if(showed)return;

        //ads

        gameTime.gameObject.SetActive(false);
        gameObject.GetComponent<SimpleSampleCharacterControl>().death();
    }

    public void showWinPanel(){
        if(gameTime.gameObject.activeSelf){
            win=true;
            gameTime.gameObject.SetActive(false);
            winPanel.SetActive(true);
            //sound.playWin();

            PlayerPrefs.SetInt("levelCompleted"+(Application.loadedLevel-1).ToString(),1);
        }
    }


    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag=="Enemy"){
            death();
            gameObject.GetComponent<Rigidbody>().freezeRotation=false;
            gameObject.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.None;
            gameObject.GetComponent<Rigidbody>().AddForce(-Vector3.forward*10);
            gameObject.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.forward*-100);

            //sound.playDeath();

            foreach(var detail in deathPanel)detail.SetActive(true);
        }
    }

    //public ParticleSystem coinGet;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Coin"){
            //coinGet.Play();
            PlayerPrefs.SetInt("coins",PlayerPrefs.GetInt("coins")+1);
            coinsText.text=PlayerPrefs.GetInt("coins").ToString();

            //sound.playCoinGet();

            Destroy(other.gameObject);
        }
    }
}
