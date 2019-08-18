using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TocarObjeto3 : MonoBehaviour {

    public GameObject objetoABorrar3;
 
    private float maxTime3 = 0.5f;
    private float lastTimeClicked3;
 
 
    void Start () {
       
    }
   
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            float deltaTime3 = Time.time - lastTimeClicked3;
 
            if(deltaTime3 < maxTime3)
            {
                //Debug.Log("Double Click!");
                Destroy (GameObject.FindWithTag("Peligroso3"));
            }
            else
            {
                //Debug.Log("Single Click!");
            }
 
            lastTimeClicked3 = Time.time;
        }
    }
}