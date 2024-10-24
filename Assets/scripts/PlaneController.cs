using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed;

    private float verticalinput;
    private float verticalturnspeed=30;

    public int updown;
    public int leftright;

    private float horizontalinput;
    private float horizontalturnspeed = 100;

    private bool boost;
    private bool brake;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (boost==true)
        {
            if (speed <= 30)
            {
                speed = speed + 0.1f*Time.deltaTime;
            }
        }
        else
        {
            if (speed > 0)
            {
                speed =speed-0.1f*Time.deltaTime;
            }
        }
        if (brake==true)
        {
            if (speed > 0)
            {
                speed = speed - 0.5f * Time.deltaTime;
            }
        }

        verticalinput =updown;
        horizontalinput = leftright;

        transform.Translate(Vector3.right * Time.deltaTime * speed);

        transform.Rotate(Vector3.back, Time.deltaTime * verticalinput*verticalturnspeed);

        transform.Rotate(Vector3.up, Time.deltaTime * horizontalinput * horizontalturnspeed);
    }

    public void Boost(bool value)
    {
        boost = value;
    }

    public void Brake(bool value)
    {
        brake = value;
    }

    public void Up(int value)
    {
        updown = value;
    }

    public void Down(int value)
    {
        updown = value;
    }

    public void Left(int value)
    {
        leftright = value;
    }

    public void Right(int value)
    {
        leftright = value;
    }

}
