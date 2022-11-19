using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patronesMovimiento : MonoBehaviour
{
    public float velocidadDesplazamiento = 1.5f;
    public float distanciaCambiarObjetivo = 0.1f;
    public GameObject[] puntosPatrulla;

   
    public int puntoActual = 0;

    // Start is called before the first frame update
    void Start()
    {
        puntosPatrulla[0] = GameObject.Find("/PuntosMovimiento/Mov1");
        puntosPatrulla[1] = GameObject.Find("/PuntosMovimiento/Mov2");
        puntosPatrulla[2] = GameObject.Find("/PuntosMovimiento/Mov3");
        puntosPatrulla[3] = GameObject.Find("/PuntosMovimiento/Mov4");
        puntosPatrulla[4] = GameObject.Find("/PuntosMovimiento/Mov5");
        puntosPatrulla[5] = GameObject.Find("/PuntosMovimiento/Mov6");
        puntosPatrulla[6] = GameObject.Find("/PuntosMovimiento/Mov7");
        puntosPatrulla[7] = GameObject.Find("/PuntosMovimiento/Mov8");
        puntosPatrulla[8] = GameObject.Find("/PuntosMovimiento/Mov9");
        puntosPatrulla[9] = GameObject.Find("/PuntosMovimiento/Mov10");
        puntosPatrulla[10] = GameObject.Find("/PuntosMovimiento/Mov11");
        puntosPatrulla[11] = GameObject.Find("/PuntosMovimiento/Mov12");
        puntosPatrulla[12] = GameObject.Find("/PuntosMovimiento/Mov13");
        puntosPatrulla[13] = GameObject.Find("/PuntosMovimiento/Mov14");
        puntosPatrulla[14] = GameObject.Find("/PuntosMovimiento/Mov15");
        puntosPatrulla[15] = GameObject.Find("/PuntosMovimiento/Mov16");
        puntosPatrulla[16] = GameObject.Find("/PuntosMovimiento/Mov17");
    }

    // Update is called once per frame
    void Update()
    {
        if(MoverAPunto()){
            puntoActual = obtenerSiguientePunto();
        }
    
    }

    private bool MoverAPunto()
    {
        Vector3 vectorDistancia = puntosPatrulla[puntoActual].transform.position - this.transform.position;
        if(vectorDistancia.magnitude < distanciaCambiarObjetivo)
        {
            return true; // Llego al punto
        }
        // Si no ha llegado moverse al punto
        Vector3 vectorVelocidad = vectorDistancia.normalized;
        this.transform.position += vectorVelocidad * velocidadDesplazamiento * Time.deltaTime;

        return false;
    }

    private int obtenerSiguientePunto()
    {
        int avanzarORetroceder = Random.Range(0,16);
        puntoActual = avanzarORetroceder;

        if(puntoActual < 0)
        {
        puntoActual = 1;
        return puntoActual;
        }

        if(puntoActual >= puntosPatrulla.Length)
        {
            puntoActual = 0;
        }

        return puntoActual;
    }


   
}
