using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndContinue : MonoBehaviour
{
    public GameObject resumepannel;
    public GameObject buttonspanel;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        resumepannel.SetActive(true);
        buttonspanel.SetActive(false);
        Time.timeScale = 0.0f;
    }
    public void Resume()
    {
        resumepannel.SetActive(false);
        buttonspanel.SetActive(true);   
        Time.timeScale = 1.0f;
    }

    public void Home()
    {
        resumepannel.SetActive(false);
        buttonspanel.SetActive(true);
        Time.timeScale = 1.0f;
    }

}
