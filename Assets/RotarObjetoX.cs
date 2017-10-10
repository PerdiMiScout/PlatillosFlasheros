using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjetoX: MonoBehaviour
{
    float Timer;
    float TiempoPausado; //solo sirve para demostrar, al final hay q borrar esta variable
    float TiempoVibrado; //tiempo durante el cual vibrara el objeto
    float AnguloX;
    float AnguloZ;
    float AnguloRotacionMaximo;
    float AnguloRotacionMinimo;
    public int Velocidad;
    int Sentido;
    // Use this for initialization
    void Start()
    {
        Timer = 0;
        TiempoVibrado = 2;
        TiempoPausado = 5;
        AnguloX = 0;
        AnguloZ = 0;
        AnguloRotacionMaximo = 10;
        AnguloRotacionMinimo = AnguloRotacionMaximo * (-1);
        Velocidad = 100;
        Sentido = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= TiempoVibrado)
        {
            AnguloX = this.gameObject.transform.localEulerAngles.x;
            AnguloZ = this.gameObject.transform.localEulerAngles.z;
            if(AnguloX > 180)
            {
                AnguloZ = AnguloZ - 360;
            }
            if (AnguloZ > 180)
            {
                AnguloZ = AnguloZ - 360;
            }
            //Si el angulo Z actual es menor al permitido, puede rotar, si no tiene q volver
            if ( AnguloZ > AnguloRotacionMaximo) //AnguloZ > 15
            {
                Sentido = -1 ;
                Debug.Log("Sentido +");
            }
            else
            {
                if (AnguloZ < AnguloRotacionMinimo) //AnguloZ < 345
                {
                    Sentido = 1;
                    Debug.Log("Sentido -");
                }
            }
            
            transform.RotateAround(transform.position, Vector3.forward, Sentido * Velocidad * Time.deltaTime);
            
            //Debug.Log("AnguloX:" + AnguloX);
            Debug.Log("AnguloZ:" + AnguloZ);
            //Debug.Log("Maximo:" + AnguloRotacionMaximo);
            //Debug.Log("Minimo:" + AnguloRotacionMinimo);
        }

        Timer += Time.deltaTime;

        if (Timer > (TiempoPausado))
        {
            Timer = 0;
        }

    }

}