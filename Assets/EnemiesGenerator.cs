using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesGenerator : MonoBehaviour
{
    public float zPos;
    public Vector2 y;

    public GameObject[] enemies;

    public float delay;

    public float n;

    public float speed=1f;

    public static bool StartedGame = false;

    void Start(){
        StartedGame = false;
        StartCoroutine(enemiesGenerator());

        // float n=20-delay*10;

        if(StartedGame)
        {
            for(int i=0;i<n;i++){
                int nn=Random.Range(0,enemies.Length);

                var enemy = Instantiate(enemies[nn], new Vector3(0, Random.Range(y[0],y[1]), i*10+20), enemies[nn].transform.rotation) as GameObject;

                enemy.GetComponent<Enemy>().speed=Random.Range(1,3)*(5-delay)/10;
            }
        }

    }
    
    IEnumerator enemiesGenerator(){
        while(StartedGame || !PlayerCollisions.win){
            if(StartedGame ){//!PlayerCollisions.win && PlayerPrefs.GetInt("studied")==1){

                int n=Random.Range(0,enemies.Length);
                var enemy = Instantiate(enemies[n], new Vector3(0, Random.Range(y[0],y[1]), zPos), enemies[n].transform.rotation) as GameObject;
                enemy.GetComponent<Enemy>().speed=Random.Range(1,3)*(5-delay)/7*speed;

            }

            yield return new WaitForSeconds(delay);
        }
    }
}
