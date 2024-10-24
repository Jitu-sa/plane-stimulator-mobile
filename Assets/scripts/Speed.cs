using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public PlaneController script;
    private float planespeed;
    public Text speedText;
    // Start is called before the first frame update
    void Start()
    {
        script = FindObjectOfType<PlaneController>();
    }

    // Update is called once per frame
    void Update()
    {
        planespeed = script.speed*10f;
        speedText.text=planespeed.ToString();  
    }
}
