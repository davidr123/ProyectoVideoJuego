using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameController : MonoBehaviour
{
      public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += EndReached;
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
    public void CargarSegundoJuego(){ 
          SceneManager.LoadScene("FireWorks");
    }
    public void CargarNivelesJuego(){ 
          SceneManager.LoadScene("Niveles");
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
      {
          UnityEngine.SceneManagement.SceneManager.LoadScene ("JuegoTornillo");
      }
}
