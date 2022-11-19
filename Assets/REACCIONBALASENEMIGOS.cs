using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REACCIONBALASENEMIGOS : MonoBehaviour
{
    public GameObject SourceHitAudio;
    public AudioSource hitSound;

    public GameObject Gun;
    public Disparar disparos;
    // Start is called before the first frame update
    void Start()
    {
        Gun = GameObject.Find("/XR Origin/Camera Offset/Right Hand/Right Hand Model/Gun");
        disparos = Gun.GetComponent<Disparar>();

        SourceHitAudio = GameObject.Find("/XR Origin/hitPlayer");
        hitSound = SourceHitAudio.GetComponent<AudioSource>();
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
            hitSound.Play();

        }
    }
}
