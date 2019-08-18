using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TocarObjeto : MonoBehaviour {

    public GameObject objetoABorrar;
 
    private float maxTime = 0.5f;
    private float lastTimeClicked;
 
 
    void Start () {
       
    }
   
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            float deltaTime = Time.time - lastTimeClicked;
 
            if(deltaTime < maxTime)
            {
                //Debug.Log("Double Click!");
                Destroy (GameObject.FindWithTag("Peligroso"));
            }
            else
            {
                //Debug.Log("Single Click!");
            }
 
            lastTimeClicked = Time.time;
        }
    }
}