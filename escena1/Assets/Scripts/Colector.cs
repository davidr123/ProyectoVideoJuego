using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colector : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (SceneManager.GetSceneByName("Juego").isLoaded)
        {
            if (target.gameObject.tag == "TornilloBueno")
            {
                print("BUENO");
                SceneManager.LoadScene("SiAciertaTornillo");   
            }
            else
            {
                print("MALO");
                SceneManager.LoadScene("SiFallaTornillo");
            }
        }else{
            if (target.gameObject.tag == "TornilloBueno")
            {
                print("BUENO");
                SceneManager.LoadScene("SiAciertaTornillo2");   
            }
            else
            {
                print("MALO");
                SceneManager.LoadScene("SiFallaTornillo2");
            }
        }

        
        

        Destroy(target.gameObject);

    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
