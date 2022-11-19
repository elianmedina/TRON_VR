using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{
    public Transform puntoAparicion;
    public GameObject proyectilLaserPrefab;
    public float velocidad = 15f;
    float temporizador;

    public float tiempoEntreBala = 5;
    public float sumandoAleatorio = 4;

    public ProceduralEnemigos cantidadEnemigos;



    // Start is called before the first frame update
    void Start()
    {
         temporizador = 0f;
         tiempoEntreBala = obtenerTiempoAleatorio();
         

    }

    // Update is called once per frame
    void Update()
    {
        temporizador += Time.deltaTime;
        bool seInvocoEnemigo = cantidadEnemigos.getInvocacion();
        

        Debug.Log (temporizador);

        if(temporizador >= tiempoEntreBala){
            //Instantiate(misilPrefab, Vector2.zero, Quaternion.identity);
            var proyectilLaser = Instantiate(proyectilLaserPrefab,puntoAparicion.transform.position,puntoAparicion.transform.rotation);
            proyectilLaser.GetComponent<Rigidbody>().velocity = (transform.forward * -1) * velocidad  +
            Random.insideUnitSphere ;
            temporizador = 0;
            Destroy(proyectilLaser, 5);
        }
    }

    public float getVelocidad(){
    return velocidad;
    }

    public float obtenerTiempoAleatorio(){
        float randomTiempoBala = Random.Range(4f,8f);
        return randomTiempoBala;
    }

    public float obtenerNumeroAleatorio(){
        float ramdomSumando = Random.Range(3f,6f);
        return ramdomSumando;
    }

    
}
