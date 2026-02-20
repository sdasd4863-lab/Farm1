using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class box : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
       
        
        if (other.gameObject.tag == "Box" )
        {
            
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            Destroy(GetComponent<Throwable>()); 
            Destroy(GetComponent<Interactable>()); 
            Destroy(GetComponent<Rigidbody>()); 
            Destroy(other.GetComponent<BoxCollider>()); 

                
        }
       
    }

   
}
