using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OdsPom : MonoBehaviour
{
    KeyCode UpW, SkokW, UpAltW, LeftW, LeftAltW, RightW, RightAltW, DownW, DownAltW, BiegW, ZapisW, WczytW;

    public Text przod;
    public Text skok2;
    public Text przod3;
    public Text left4;
    public Text left5;
    public Text right6;
    public Text right7;
    public Text Down;
    public Text DownAlt;
    public Text Bieg;
    public Text Zapis;
    public Text Wczyt;

    Scene scena;
    // Start is called before the first frame update
    void Start()
    {
        scena = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (PlayerPrefs.HasKey("Up"))
                UpW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up"));
            if (PlayerPrefs.HasKey("Skok"))
                SkokW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Skok"));
            if (PlayerPrefs.HasKey("UpAlt2"))
                UpAltW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("UpAlt2"));
            if (PlayerPrefs.HasKey("Left"))
                LeftW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left"));
            if (PlayerPrefs.HasKey("LeftAlt"))
                LeftAltW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("LeftAlt"));
            if (PlayerPrefs.HasKey("Right"))
                RightW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right"));
            if (PlayerPrefs.HasKey("RightAlt"))
                RightAltW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("RightAlt"));
            if (PlayerPrefs.HasKey("Down"))
                DownW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down"));
            if (PlayerPrefs.HasKey("DownAlt"))
                DownAltW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("DownAlt"));
            if (PlayerPrefs.HasKey("Shift"))
                BiegW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Shift"));
            if (PlayerPrefs.HasKey("Zapis"))
                ZapisW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zapis"));
            if (PlayerPrefs.HasKey("Wczytaj"))
                WczytW = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Wczytaj"));


            przod.text = UpW.ToString();
            skok2.text = SkokW.ToString();
            przod3.text = UpAltW.ToString();
            left4.text = LeftW.ToString();
            left5.text = LeftAltW.ToString();
            right6.text = RightW.ToString();
            right7.text = RightAltW.ToString();
            Down.text = DownW.ToString();
            DownAlt.text = DownAltW.ToString();
            Bieg.text = BiegW.ToString();
            Zapis.text = ZapisW.ToString();
            Wczyt.text = WczytW.ToString();
   } 
}
