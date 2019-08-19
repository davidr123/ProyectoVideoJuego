using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiempoLimiteFireworks2 : MonoBehaviour
{

    public float timeLeft = 10.0f;
    public Text startText; // used for showing countdown


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            //Do something useful or Load a new game scene depending on your use-case
            SceneManager.LoadScene("SiFallaFireworks2");
        }
    }
}
