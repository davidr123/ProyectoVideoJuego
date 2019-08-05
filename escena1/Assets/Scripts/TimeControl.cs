using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerLeftScript.timeLeft <=0){
            //Time.timeScale = 0;
            SceneManager.LoadScene("SiFallaBirthday");
        }
    }
}
