using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLeftScript : MonoBehaviour
{
    Text text;
    public static float timeLeft = 5f;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        //text = GameObject.Find("TimeLeftText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0){
            text.text = "Tiempo Restante: " + Mathf.Round(timeLeft);
        }
    }
}
