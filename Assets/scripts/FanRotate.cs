using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    public float fanspeed=0;

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
            if (fanspeed < 2000)
            {
                fanspeed = fanspeed + 500*Time.deltaTime;
            }
        }
        else
        {
            if (fanspeed > 200)
            {
                fanspeed = fanspeed - 100 * Time.deltaTime;
            }
        }

        transform.Rotate(Vector3.right, Time.deltaTime *fanspeed);

    }

    public void Boost(bool value)
    {
        boost = value;
    }

}
