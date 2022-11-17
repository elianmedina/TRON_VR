using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralEnemigos : MonoBehaviour
{
    public GameObject[] objeto;
    public GameObject PuntoAparicion;
    public bool invocarEnemigo;
    public float cronometro;
    public float tiempoInvocar, intervalo;

    public float probabilidadAparicion = 0.75f;


    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        Reloj();
        if (invocarEnemigo== true)
        {
            PuntoAparicion = transform.GetChild(Random.Range(0, 4)).gameObject; // 0 a 4 corresponde al total de puntos posibles de aparición
            float tiempoVida = cronometro;
            if (Random.Range(0f, 1f) <= probabilidadAparicion)
            {
                Instantiate(objeto[Random.Range(0, objeto.Length)],
                PuntoAparicion.transform.position, Quaternion.Euler(Vector3.up * (Random.Range(0, 4) * 90)));
                invocarEnemigo = false;


            }

        }


    }
    void Reloj()
    {
        cronometro += (Time.deltaTime);
        // Debug.Log(cronometro.ToString());
        if (invocarEnemigo == false)
        {
            if (cronometro >= tiempoInvocar)
            {
                invocarEnemigo = true;
                cronometro = 0;
            }
        }



    }
}
