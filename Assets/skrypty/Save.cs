using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    KeyCode Zap, Wczyt;
    int scena;

    private void Start()
    {
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
        gameObject.transform.position = new Vector3(PlayerPrefs.GetFloat("PolX"),PlayerPrefs.GetFloat("PolY"), PlayerPrefs.GetFloat("PolZ"));
       punktacja.wynik = PlayerPrefs.GetInt("Wynik");
       Zycie.zycie = PlayerPrefs.GetInt("ILZY");
        PlayerPrefs.GetString("NicK");
        PlayerPrefs.GetInt("Klasa");

        Debug.Log("Wczytano");
    }
    public void Zapisz()
    {
        PlayerPrefs.SetInt("ZapisanaPlansza", scena);
        PlayerPrefs.SetFloat("PolX", gameObject.transform.position.x);
        PlayerPrefs.SetFloat("PolY", gameObject.transform.position.y);
        PlayerPrefs.SetFloat("PolZ", gameObject.transform.position.z);
        PlayerPrefs.SetInt("Wynik", punktacja.wynik);
        PlayerPrefs.SetInt("ILZY", Zycie.zycie);
        PlayerPrefs.SetInt("MozKonWyg", 1);

        PlayerPrefs.Save();
        Debug.Log("Zapisano");
    }
}
