using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{
    public Transform puntoAparicion;
    public GameObject proyectilLaserPrefab;
    public float velocidad = 15f;
    public float tiempoEntreBala = 5f;
    float temporizador;



    // Start is called before the first frame update
    void Start()
    {
         temporizador = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        temporizador += Time.deltaTime;

        


        Debug.Log (temporizador);

        if(temporizador >= tiempoEntreBala){
            //Instantiate(misilPrefab, Vector2.zero, Quaternion.identity);
            var proyectilLaser = Instantiate(proyectilLaserPrefab,puntoAparicion.transform.position,puntoAparicion.transform.rotation);
            proyectilLaser.GetComponent<Rigidbody>().velocity = (transform.forward * -1) * velocidad  +
          Random.insideUnitSphere ;
            temporizador = 0;
        }
    }

    public float getVelocidad(){
    return velocidad;
    }
}
