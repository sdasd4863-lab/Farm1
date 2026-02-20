using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invis : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ss")
        {
            
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.enabled = false;

        }
    }
    
}
