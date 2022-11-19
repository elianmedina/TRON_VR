using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reaccionabalas : MonoBehaviour
{

    public Disparar disparos;
    // Start is called before the first frame update

    private void Start()
    {

    }

    private void Update()
    {
    
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bala"))
        {
            disparos.puntosTotales += 100;
            Destroy(gameObject);
            
        }
    }
}
