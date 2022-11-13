using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoBala : MonoBehaviour
{

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


    }

    void Awake() {
        Destroy(gameObject, 5);
    }
}
