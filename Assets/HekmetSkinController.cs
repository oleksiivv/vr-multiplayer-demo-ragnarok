using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HekmetSkinController : MonoBehaviour
{
    public MeshRenderer helmet;
    public Material[] skins;

    void Start(){
        helmet.material=skins[PlayerPrefs.GetInt("CurrentPlayerMaterial")];
    }
}
