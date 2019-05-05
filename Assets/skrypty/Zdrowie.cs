using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zdrowie : MonoBehaviour
{

    public int zyciemoba = 100;
    public int punkt = 5;

    public void Obrazeniaotrzy(int obrazenia)
    {
        zyciemoba -= obrazenia;

        if (zyciemoba <= 0)
        {
            Smierc();
            punktacja.wynik += 5;
        }
    }

    public void Smierc()
    {
        Destroy(gameObject);
    }

    public bool Zabicie()
    {
        if (zyciemoba <= 0)
        {
            return true;
        }
        return false;
    }

}
