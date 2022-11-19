using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinch;
    public InputActionProperty grip;

    public Animator animator;
    
    


    public bool seDisparo;

    // Start is called before the first frame update
    void Start()
    {
        seDisparo = false;
        
    }

    // Update is called once per frame
  
  
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       float triggerValue=  pinch.action.ReadValue<float>();

        animator.SetFloat("Trigger", triggerValue);
        


       float gripValue = grip.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);

        if (gripValue >= 0.8f && gripValue <= 0.9f)
        {
            seDisparo = true;


        }
        else
        {
            seDisparo = false;
        }
        

    }

   
    public bool getDisparar()
    {
        return seDisparo;
    }



}
