using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;
public class flag : MonoBehaviour
{
    public Text boxText;
    public Text boxCik;
    public int i;
    public int c;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ss" )
        {

            i ++;  boxText.text = i.ToString();

        }
        if (other.gameObject.tag == "cik"&& c !=5)
        {

            c++; boxCik.text = c.ToString();

        }
    }
}
