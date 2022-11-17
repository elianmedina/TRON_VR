using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperReflectorFlipanteEspiralidoso : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject referencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision rasholaser) {
        if (rasholaser.gameObject.tag == "RashoLaser"){
        Debug.Log ("BLOQUEEE UN RASHO LASEEEERRRR");
        Vector3 direccion = rasholaser.gameObject.transform.position - enemigo.transform.position ;
       
        rasholaser.gameObject.GetComponent<Rigidbody>().velocity = direccion * referencia.GetComponent<disparoEnemigo>().velocidad;
        
   }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
