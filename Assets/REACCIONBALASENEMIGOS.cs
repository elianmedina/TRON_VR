using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REACCIONBALASENEMIGOS : MonoBehaviour
{
    public Disparar disparos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RashoLaser"))
        {
            disparos.vidasTotales -= 1;
          

        }
    }
}
