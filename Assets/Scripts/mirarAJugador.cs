using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirarAJugador : MonoBehaviour
{
    public GameObject jugador;
    public float velocidadApuntado = 5f;
    public Transform objetoQueVaAMirar;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("XR Origin");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = objetoQueVaAMirar.transform.position - jugador.transform.position ;
        Quaternion rotacion = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Lerp(transform.rotation,rotacion, velocidadApuntado * Time.deltaTime);
    }
}
