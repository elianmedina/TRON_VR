using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reaccionabalas : MonoBehaviour
{
   
    public AudioSource explosion;
    public Disparar disparos;
    public GameObject Gun;
    // Start is called before the first frame update

    private void Start()
    {
        Gun = GameObject.Find("/XR Origin/Camera Offset/Right Hand/Right Hand Model/Gun");
        disparos = Gun.GetComponent<Disparar>();

        
        explosion = gameObject.GetComponent<AudioSource>();//Probar
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
            explosion.Play();
            Destroy(gameObject);
            
        }
    }
}
