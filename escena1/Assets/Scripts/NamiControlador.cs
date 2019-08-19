using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class NamiControlador : MonoBehaviour {
    public ControladorTiempo tiempo;
    
    [SerializeField] private Transform nami;
    [SerializeField] private Transform constructor;
    public Vector3 initialPosition;
    public Vector2 mousepostion;
    public float deltaX, deltaY;
    public static bool locked;
    public Animator anim,anim2;
    public float manzana;
    public GameObject poptext;
    public AudioSource audioNamiFeliz;
    
    public GameObject explosioneffect,estrellaeffect;
    //public Animation anim;

    // Use this for initialization
    void Start () {
       
    }

    private void Awake()
    {
     
    }

    private void OnMouseDown()
    {
      // print("tocar");
        if (!locked)
        {
            //print(gameObject.transform.position);
            initialPosition = gameObject.transform.position;
            // initialPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

          

        }
    }

    private void OnMouseDrag()
    {
       
            //print("cojiendo");
            if (!locked)
        {

            // SceneManager.GetSceneByName("Juego");
            
            //if (SceneManager.GetSceneByName(bandera.tempNombre).isLoaded)
            if (SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("JuegoTornillo2").isLoaded)
            {
                mousepostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(mousepostion.x - deltaX, mousepostion.y - deltaY);
            }

           
        }
    
    }
   

  
   

    void OnTriggerEnter2D(Collider2D col)
    {
        //ESCENA JUEGO
        //Para los agujeros
        if (col.gameObject.tag == "nami")
        {
           // tiempo = FindObjectOfType<ControladorTiempo>();
        

           // puntaje.IncrementarPuntaje(gameObject.tag);


            

            

            


           


               
           
        }
    }
    // Update is called once per frame
    void Update () {
      
	}
}
