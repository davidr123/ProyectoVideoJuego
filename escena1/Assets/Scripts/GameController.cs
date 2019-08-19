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
    public void CargarSiFallaFireworks2()
    {
        SceneManager.LoadScene("SiFallaFireworks2");
    }
    public void CargarSiAciertaFireworks2()
    {
        SceneManager.LoadScene("SiAciertaFireworks2");
    }
    public void Fireworks2()
    {
        SceneManager.LoadScene("Fireworks2");
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
          SceneManager.LoadScene("IntroFireworks");
    }
    public void CargarTercerJuego(){ 
          SceneManager.LoadScene("IntroBirthday");
          //SceneManager.LoadScene("Birthday");
    }
    public void CargarNivelesJuego(){ 
          SceneManager.LoadScene("Niveles");
    }
    public void SiPresiona(){ 
          SceneManager.LoadScene("SiAciertaBirthday");
    }
    public void NoPresiona(){ 
          SceneManager.LoadScene("SiFallaBirthday");
    }
    public void FallaBirthday2(){ 
          SceneManager.LoadScene("SegundoRetoBirthday");
    }
    public void CargarMenuJuegos(){ 
          SceneManager.LoadScene("MenuJuegos");
    }
    public void CargarNivelesmontaña(){ 
          SceneManager.LoadScene("NivelesMontana");
    }
    public void CargarNivelesFuego(){ 
          SceneManager.LoadScene("NivelesFuego");
    }
    public void CargarNivelesCumple(){ 
          SceneManager.LoadScene("NivelesCumple");
    }
    public void CargarSegundoJuegoMontaña(){ 
          SceneManager.LoadScene("JuegoTornillo2");
    }
    public void SiguienteEscena(){ 
          SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
      {
          //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
      }
}
