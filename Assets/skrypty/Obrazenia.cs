using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obrazenia : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
           
           Zycie.zycie -= 25;
            
        }
    }
}
