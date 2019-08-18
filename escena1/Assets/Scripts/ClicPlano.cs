using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClicPlano : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (/*GameObject.Find("Plano").GetComponent<Image>() && */ Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("SiFallaTornillo");
        }
    }
}
