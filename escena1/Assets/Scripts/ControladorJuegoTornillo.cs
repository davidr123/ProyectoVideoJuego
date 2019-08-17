using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJuegoTornillo : MonoBehaviour
{

    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(TornilloEstrella.locked)
        {
            Debug.Log("pieza correcta");
            //SceneManager.LoadScene("SiAciertaTornillo");
        }
        else{
            Debug.Log("pieza correcta");
            //SceneManager.LoadScene("SiFallaTornillo");
        }
    }

}