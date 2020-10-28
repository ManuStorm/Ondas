using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onda : MonoBehaviour
{ public float timer;
public float Velocidad;
public float Amplitud;
public float Periodo;
public float Longuitud;
public float δesfase;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    float UpdateOnda(float x,float t, float T, float v,float A,float l,float δ)
    {
        float r;
        float ω=2*Mathf.PI/(T/v);
        float k=2*Mathf.PI/l;
        r=A*Mathf.Sin(ω*t+k*x+δ);
        return r;
    }

    // Update is called once per frame
    void Update()
    {
        timer=timer+1*Time.deltaTime;
        float y=UpdateOnda(gameObject.GetComponent<Transform>().position.x,timer,Periodo,Velocidad,Amplitud,Longuitud,δesfase);
        gameObject.GetComponent<Transform>().position=new Vector3(gameObject.GetComponent<Transform>().position.x,y,gameObject.GetComponent<Transform>().position.z);
    }
}
