using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Disparar : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPoint;
    public float firespeed = 20;
    public float ultimoEnter;
    public AnimateHandOnInput obtenerDisparo;
    public int puntosTotales;
    public Text puntosText;
    public AudioSource audioDisparo;
    public Text vidasText;
    public int vidasTotales;
    void Start()
    {
        puntosTotales = 0;
        vidasTotales = 5;
        audioDisparo = gameObject.GetComponent<AudioSource>();
}

    // Update is called once per frame
    void Update()
    {

        FireBullet();

        if (obtenerDisparo.getDisparar() == true)
        {
            FireBullet();
        }
        puntosText.text = puntosTotales.ToString();
        vidasText.text = vidasTotales.ToString();

        if(puntosTotales >= 1500)
        {
            SceneManager.LoadScene("EscenaFinal");
        }
        if (vidasTotales <= 0)
        {
            SceneManager.LoadScene("MainVR");
        }
    }

    public void FireBullet()
    {
        if(Time.time > ultimoEnter + 1.5f)
        {
            audioDisparo.Play();
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.transform.rotation = spawnPoint.rotation;
            spawnedBullet.GetComponent<Rigidbody>().velocity = (spawnPoint.up * -1) * firespeed;
            Destroy(spawnedBullet, 2);
            obtenerDisparo.seDisparo = false;
            ultimoEnter = Time.time;
        }
       
       


    }

  

}
