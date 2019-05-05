using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocisk : MonoBehaviour
{
     int obr = 25;

    void OnCollisionEnter(Collision col)
    {
        GameObject go = col.gameObject;
        Zdrowie zdr = (Zdrowie)go.GetComponent<Zdrowie>();
        if(zdr != null)
        {
            zdr.Obrazeniaotrzy(obr);
        }
    }
}
