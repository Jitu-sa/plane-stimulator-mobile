using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour
{
    public AudioSource sound;

    private float Volume = 0;

    public bool boost;
    // Start is called before the first frame update
    void Start()
    {
        boost = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (boost==true)
        {
            if (Volume < 1)
            {
                Volume = Volume + 0.1f*Time.deltaTime; 
            }    
        }
        else
        {
            if(Volume > 0.1)
            {
                Volume =Volume-0.1f*Time.deltaTime;
            }
        }

        sound.volume = Volume;
    }
    public void Boost(bool value)
    {
        boost = value;
    }

    public void PAUSE(bool v)
    {
        sound.Pause();
    }

    public void RESUME(bool v)
    {
        sound.Play();
    }

}
