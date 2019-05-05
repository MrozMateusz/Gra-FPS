using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Scene scena;
    public GameObject kon;
    public int mozKonWyg = 1;
    public float timerZ = 0.0f;
    public static bool czas_zatrzym = false;

    //Skrypt kończący grę


    void Start()
    {
       
        mozKonWyg = 1;
        PlayerPrefs.SetInt("MozKonWyg", mozKonWyg);
        
    }

    void Update()
    {
        timerZ = Time.deltaTime;

        scena = SceneManager.GetActiveScene();

        if (kon.activeSelf)
        {
            Time.timeScale = 0;
            czas_zatrzym = true;
        }
        else
        {
           Time.timeScale = 1;
            czas_zatrzym = false;
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            kon.SetActive(true);
            Cursor.visible = true;
            mozKonWyg = 0;

            PlayerPrefs.SetInt("MozKonWyg", mozKonWyg);
        }
    }

}
