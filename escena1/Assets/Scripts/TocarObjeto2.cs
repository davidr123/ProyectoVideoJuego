using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TocarObjeto2 : MonoBehaviour {

    public GameObject objetoABorrar2;
 
    private float maxTime2 = 0.5f;
    private float lastTimeClicked2;
 
 
    void Start () {
       
    }
   
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            float deltaTime = Time.time - lastTimeClicked2;
 
            if(deltaTime < maxTime2)
            {
                //Debug.Log("Double Click!");
               Destroy (GameObject.FindWithTag("Peligroso2"));
            }
            else
            {
                //Debug.Log("Single Click!");
            }
 
            lastTimeClicked2 = Time.time;
        }
    }
}