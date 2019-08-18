using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colector : MonoBehaviour {
    //public ControladorTiempo tiempo;
    //public ControladorVidas vidas;
    public int temp;
    public GameObject TornilloB, TornilloM;

    private void OnTriggerEnter2D(Collider2D target)
    {
        
      
        Destroy(TornilloB.gameObject);

    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
