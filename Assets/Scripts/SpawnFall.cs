using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFall : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    private Quaternion cameratilt;
    private Vector3 Pos;
//-12 to 11x
//-4 to -2z
//12 to 17y
void Start(){
    spawnobjects();
}

private void spawnobjects(){
    GameObject thing = prefab1;
    int Var = Random.Range(1, 3);
    if(Var == 1){
        thing = prefab1;
    }else if (Var == 2){
        thing = prefab2;
    }else{
        Debug.Log("ruh roh raggy the prefab didn't get registered");
    }
    Pos = new Vector3(Random.Range(-12, 11), Random.Range(12, 17), Random.Range(-4, -2));
    Instantiate(thing, Pos, cameratilt);
    Invoke("spawnobjects", 2);
}
}
