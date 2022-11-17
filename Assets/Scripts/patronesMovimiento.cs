using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patronesMovimiento : MonoBehaviour
{
    public float velocidadDesplazamiento = 1.5f;
    public float distanciaCambiarObjetivo = 0.1f;
    public Transform[] puntosPatrulla;

    

    public int puntoActual = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
        Vector3 vectorDistancia = puntosPatrulla[puntoActual].position - this.transform.position;
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
