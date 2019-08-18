using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneradorAlimentos : MonoBehaviour {


    [SerializeField]
    public GameObject[] frutas;


    public bool bandera, regulador, constructor, energetico;
    public int numTemp, numero;

    private BoxCollider2D col;
    float x1, x2;

    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;

    }
    void Start()
    {
        StartCoroutine(GenerarAlimentos(1f));
    }

    IEnumerator GenerarAlimentos(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        
        temp.x = Random.Range(x1, x2);

        
            Instantiate(frutas[Random.Range(0, frutas.Length)], temp, Quaternion.identity);
            
        


        
            StartCoroutine(GenerarAlimentos(3f));

        


    }
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        
    }
	
}