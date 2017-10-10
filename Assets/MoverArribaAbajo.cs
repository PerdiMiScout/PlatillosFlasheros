using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverArribaAbajo : MonoBehaviour {
    bool Up ;
    float Timer;
    float TiempoPausa;
    // Use this for initialization
    void Start () {
        Up = true;
        Timer = 0;
        TiempoPausa = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= TiempoPausa)
        {
            if (Up)
            {
                this.transform.Translate(0, 0.2f, 0);
                Up = false;
            }
            else
            {
                this.transform.Translate(0, -0.2f, 0);
                Up = true;
            }
            
        }

        Timer += Time.deltaTime;
        //Debug.Log("Delta:" + Time.deltaTime);
        //Debug.Log("Timer:" + Timer);
        if (Timer > (TiempoPausa*2f))
        {
            Timer = 0;
            
        }
       
    }
    
}
