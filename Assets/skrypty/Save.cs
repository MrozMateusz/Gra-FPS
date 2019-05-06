using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    KeyCode Zap, Wczyt;
    int scena;
    public Transform tr;
    public static Vector3 miejsceRespawnu;
    public static Vector3 poczresp;
    private GameObject respawnPlace;
    int zapisano;

    private void Awake()
    {
        if (PlayerPrefs.GetFloat("PozX") != 0 && PlayerPrefs.GetFloat("PozY") != 0 && PlayerPrefs.GetFloat("PozZ") != 0)
        {
            float PX = PlayerPrefs.GetFloat("PozX");
            miejsceRespawnu = new Vector3(PlayerPrefs.GetFloat("PozX"), PlayerPrefs.GetFloat("PozY"), PlayerPrefs.GetFloat("PozZ"));
            this.transform.position = miejsceRespawnu;
        }
        else
        {
            respawnPlace = GameObject.FindGameObjectWithTag("Respawn");
            miejsceRespawnu = respawnPlace.transform.position;
            this.transform.position = miejsceRespawnu;

            poczresp = miejsceRespawnu;

            if (MenedzerMenu.gra_od_nowa == true)
            {
                miejsceRespawnu = poczresp;
                MenedzerMenu.gra_od_nowa = false;
            }
        }
    }

    private void Start()
    {
        zapisano = 0;
        PlayerPrefs.SetInt("Zapisano", zapisano);
        tr = GetComponent<Transform>();
        if (PlayerPrefs.HasKey("Zapis"))
            Zap = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zapis"));
        if (PlayerPrefs.HasKey("Wczytaj"))
            Wczyt = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Wczytaj"));
    }

    // Update is called once per frame
    void Update()
    {
        scena = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(Zap))
        {
            Zapisz();
        }

        if (Input.GetKeyDown(Wczyt))
        {
            Wczytaj();
        }
    }

   public void Wczytaj()
    {
        tr.position = new Vector3(PlayerPrefs.GetFloat("PolX"),PlayerPrefs.GetFloat("PolY"), PlayerPrefs.GetFloat("PolZ"));
       punktacja.wynik = PlayerPrefs.GetInt("Wynik");
       Zycie.zycie = PlayerPrefs.GetInt("ILZY");
        PlayerPrefs.GetString("NicK");
        PlayerPrefs.GetInt("Klasa");

        Debug.Log("Wczytano");
    }
    public void Zapisz()
    {
        PlayerPrefs.SetInt("ZapisanaPlansza", scena);
        PlayerPrefs.SetFloat("PolX", tr.position.x);
        PlayerPrefs.SetFloat("PolY", tr.position.y);
        PlayerPrefs.SetFloat("PolZ", tr.position.z);
        PlayerPrefs.SetInt("Wynik", punktacja.wynik);
        PlayerPrefs.SetInt("ILZY", Zycie.zycie);
        PlayerPrefs.SetInt("MozKonWyg", 1);
        zapisano = 1;
        PlayerPrefs.SetInt("Zapisano", zapisano);

        PlayerPrefs.Save();
        Debug.Log("Zapisano");
    }
}
