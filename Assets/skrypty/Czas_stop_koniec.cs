using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Czas_stop_koniec : MonoBehaviour
{
    public static bool czas_zatrzym_koniec = false;
    public GameObject helpPocz;
    public GameObject Koniec;
    public GameObject helpMenu;

    // Update is called once per frame
    void Update()
    {

        if (helpPocz.activeSelf  || Koniec.activeSelf || helpMenu.activeSelf)
        {
            Time.timeScale = 0;
            czas_zatrzym_koniec = true;
        }
        else
        {
            Time.timeScale = 1;
            czas_zatrzym_koniec = false;
        }

    }
}
