using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotarcohete : MonoBehaviour
{
    [SerializeField]
    float eulerAngZ;



    private void OnMouseDown()
    {
        transform.Rotate(0f, 0f, -10f);

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //OnMouseDown();
            transform.Rotate(0f, 0f, -10f);

            eulerAngZ = transform.localEulerAngles.z;
            if (eulerAngZ >= 90f)
            {
                print("hola");
                SceneManager.LoadScene("SiAciertaFireworks2");
            }
        }

    }

}
