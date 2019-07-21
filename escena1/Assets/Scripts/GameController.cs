using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CargarJuego(){ 
          SceneManager.LoadScene("Principal");
    }
    public void CargarIntro(){ 
          SceneManager.LoadScene("Intro");
    }
    public void CargarPrimerJuego(){ 
          SceneManager.LoadScene("PrimerJuego");
    }
}
