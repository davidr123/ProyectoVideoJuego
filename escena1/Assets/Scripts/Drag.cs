using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Drag : MonoBehaviour {

    

    //public ContadorAlimentos contAli;
    [SerializeField] private Transform TornilloBueno, TornilloMalo;

    public Vector3 initialPosition;
    public Vector2 mousepostion;
    public float deltaX, deltaY;
    public static bool locked;

    // Use this for initialization
    void Start()
    {
        

    }

    private void Awake()
    {

    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            initialPosition = gameObject.transform.position;
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
                mousepostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(mousepostion.x - deltaX, mousepostion.y - deltaY);     
        }
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        //ESCENA JUEGO
        //Para los agujeros
        if (col.gameObject.tag != "Slot")
        {
            if (gameObject.tag == "TornilloBueno")
            {
                SceneManager.LoadScene("SiAciertaTornillo");
            }else{
                SceneManager.LoadScene("SiFallaTornillo");
            }
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
