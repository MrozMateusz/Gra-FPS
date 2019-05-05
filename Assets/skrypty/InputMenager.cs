﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputMenager : MonoBehaviour
{
    [SerializeField]
    public Dictionary<string, KeyCode> klawisze;

    public Text skok1;
    public Text skok2;
    public Text skok3;
    public Text left4;
    public Text left5;
    public Text right6;
    public Text right7;
    public Text dol8;
    public Text dol9;
    public Text shift;
    public Text zapis;
    public Text wczyt;

    private GameObject wybranyklawisz;

    Scene scena;

    public Slider naz1;
    public Toggle naz2;
    public Dropdown naz3;
    public Button naz4, naz5, naz6, naz7, naz8, naz9, naz10, naz11, naz12, naz13, naz14, naz15, naz16, naz17, naz18, naz19, naz20;

    public GameObject error;
    public GameObject ZapisanieOpcji;
    public static bool errorActiv;
    // Start is called before the first frame update
    void Start()
    {
        klawisze = new Dictionary<string, KeyCode>();
        scena = SceneManager.GetActiveScene();
        errorActiv = false;

        if (scena.name == "Menu") {
            
                if (!klawisze.ContainsKey("Up"))
                {
                    klawisze.Add("Up", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up", "W")));
                }
                if (!klawisze.ContainsKey("Skok"))
                {
                    klawisze.Add("Skok", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Skok", "Space")));
                }
                if (!klawisze.ContainsKey("UpAlt2"))
                {
                    klawisze.Add("UpAlt2", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("UpAlt2", "UpArrow")));
                }
                if (!klawisze.ContainsKey("Left"))
                {
                    klawisze.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
                }
                if (!klawisze.ContainsKey("LeftAlt"))
                {
                    klawisze.Add("LeftAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("LeftAlt", "LeftArrow")));
                }
                if (!klawisze.ContainsKey("Right"))
                {
                    klawisze.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));
                }
                if (!klawisze.ContainsKey("RightAlt"))
                {
                    klawisze.Add("RightAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("RightAlt", "RightArrow")));
                }
            if (!klawisze.ContainsKey("Down"))
            {
                klawisze.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "DownArrow")));
            }
            if (!klawisze.ContainsKey("DownAlt"))
            {
                klawisze.Add("DownAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("DownAlt", "S")));
            }
            if (!klawisze.ContainsKey("Shift"))
            {
                klawisze.Add("Shift", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Shift", "LeftControl")));
            }
            if (!klawisze.ContainsKey("Zapis"))
            {
                klawisze.Add("Zapis", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zapis", "F5")));
            }
            if (!klawisze.ContainsKey("Wczytaj"))
            {
                klawisze.Add("Wczytaj", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Wczytaj", "F8")));
            }



            skok1.text = klawisze["Up"].ToString();
        skok2.text = klawisze["Skok"].ToString();
        skok3.text = klawisze["UpAlt2"].ToString();
        left4.text = klawisze["Left"].ToString();
        left5.text = klawisze["LeftAlt"].ToString();
        right6.text = klawisze["Right"].ToString();
        right7.text = klawisze["RightAlt"].ToString();
        dol8.text = klawisze["Down"].ToString();
        dol9.text = klawisze["DownAlt"].ToString();
            shift.text = klawisze["Shift"].ToString(); ;
            zapis.text = klawisze["Zapis"].ToString(); ;
            wczyt.text = klawisze["Wczytaj"].ToString(); ;

        }
    }

    private void Update()
    {
        if(errorActiv == true || ZapisanieOpcji.activeSelf)
        {
            naz1.interactable = false;
            naz2.interactable = false;
            naz3.interactable = false;
            naz4.interactable = false;
            naz5.interactable = false;
            naz6.interactable = false;
            naz7.interactable = false;
            naz8.interactable = false;
            naz9.interactable = false;
            naz10.interactable = false;
            naz11.interactable = false;
            naz12.interactable = false;
            naz13.interactable = false;
            naz14.interactable = false;
            naz15.interactable = false;
            naz16.interactable = false;
            naz17.interactable = false;
            naz18.interactable = false;
            naz19.interactable = false;
            naz20.interactable = false;
        }
        else
        {
            naz1.interactable = true;
            naz2.interactable = true;
            naz3.interactable = true;
            naz4.interactable = true;
            naz5.interactable = true;
            naz6.interactable = true;
            naz7.interactable = true;
            naz8.interactable = true;
            naz9.interactable = true;
            naz10.interactable = true;
            naz11.interactable = true;
            naz12.interactable = true;
            naz13.interactable = true;
            naz14.interactable = true;
            naz15.interactable = true;
            naz16.interactable = true;
            naz17.interactable = true;
            naz18.interactable = true;
            naz19.interactable = true;
            naz20.interactable = true;
        }
    }


    private void OnGUI()
    {
        if(wybranyklawisz != null)
        {
            Event e = Event.current;
            KeyCode wejscie = e.keyCode;

        if(e.isKey && wejscie != KeyCode.Escape && wejscie != KeyCode.F1 && wejscie != klawisze["Zapis"] && wejscie != klawisze["Wczytaj"] && wejscie != klawisze["Shift"] && wejscie != klawisze["Down"] && wejscie != klawisze["DownAlt"] && wejscie != klawisze["Up"] && wejscie != klawisze["Skok"] && wejscie != klawisze["UpAlt2"] && wejscie != klawisze["Left"] && wejscie != klawisze["LeftAlt"] && wejscie != klawisze["Right"] && wejscie != klawisze["RightAlt"])
            {
                klawisze[wybranyklawisz.name] = e.keyCode;

                wybranyklawisz.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                wybranyklawisz.GetComponent<Image>().color = Color.white;
                wybranyklawisz = null;
                return;
            }
        if(e.isKey && wejscie == KeyCode.Escape || wejscie == KeyCode.F1 || wejscie == klawisze["Zapis"] || wejscie == klawisze["Wczytaj"] || wejscie == klawisze["Shift"] || wejscie == klawisze["Down"] || wejscie == klawisze["DownAlt"] || wejscie == klawisze["Up"] || wejscie == klawisze["Skok"] || wejscie == klawisze["UpAlt2"] || wejscie == klawisze["Left"] || wejscie == klawisze["LeftAlt"] || wejscie == klawisze["Right"] || wejscie == klawisze["RightAlt"])
            {
                wybranyklawisz.transform.GetChild(0).GetComponent<Text>().text = klawisze[wybranyklawisz.name].ToString();
                wybranyklawisz.GetComponent<Image>().color = Color.white;
                wybranyklawisz = null;

                
                error.SetActive(true);
                errorActiv = true;
                return;
            }

        }
    }

    public void ZmienKlawisz(GameObject klikniety)
    {
        if(wybranyklawisz != null)
        {
            wybranyklawisz.GetComponent<Image>().color = Color.white;
        }

        wybranyklawisz = klikniety;
        wybranyklawisz.GetComponent<Image>().color = Color.red;
    }

    public void ZapiszKlawisze()
    {
        foreach(var klaw in klawisze)
        {
            PlayerPrefs.SetString(klaw.Key, klaw.Value.ToString());
            
        }
            PlayerPrefs.Save();
    }

    public void DomyKlaw()
    {

        PlayerPrefs.SetString("Up", "W"); 
        PlayerPrefs.SetString("Skok", "Space"); 
        PlayerPrefs.SetString("UpAlt2", "UpArrow"); 
        PlayerPrefs.SetString("Left", "A"); 
        PlayerPrefs.SetString("LeftAlt", "LeftArrow"); 
        PlayerPrefs.SetString("Right", "D"); 
        PlayerPrefs.SetString("RightAlt", "RightArrow");
        PlayerPrefs.SetString("Down", "DownArrow");
        PlayerPrefs.SetString("DownAlt", "S");
        PlayerPrefs.SetString("Shift", "LeftControl");
        PlayerPrefs.SetString("Zapis", "F5");
        PlayerPrefs.SetString("Wczytaj", "F8");
        

        klawisze.Clear();

        if (!klawisze.ContainsKey("Up"))
        {
            klawisze.Add("Up", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up", "W")));
        }
        if (!klawisze.ContainsKey("Skok"))
        {
            klawisze.Add("Skok", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Skok", "Space")));
        }
        if (!klawisze.ContainsKey("UpAlt2"))
        {
            klawisze.Add("UpAlt2", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("UpAlt2", "UpArrow")));
        }
        if (!klawisze.ContainsKey("Left"))
        {
            klawisze.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
        }
        if (!klawisze.ContainsKey("LeftAlt"))
        {
            klawisze.Add("LeftAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("LeftAlt", "LeftArrow")));
        }
        if (!klawisze.ContainsKey("Right"))
        {
            klawisze.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));
        }
        if (!klawisze.ContainsKey("RightAlt"))
        {
            klawisze.Add("RightAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("RightAlt", "RightArrow")));
        }
        if (!klawisze.ContainsKey("Down"))
        {
            klawisze.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "DownArrow")));
        }
        if (!klawisze.ContainsKey("DownAlt"))
        {
            klawisze.Add("DownAlt", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("DownAlt", "S")));
        }
        if (!klawisze.ContainsKey("Shift"))
        {
            klawisze.Add("Shift", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Shift", "LeftControl")));
        }
        if (!klawisze.ContainsKey("Zapis"))
        {
            klawisze.Add("Zapis", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zapis", "F5")));
        }
        if (!klawisze.ContainsKey("Wczytaj"))
        {
            klawisze.Add("Wczytaj", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Wczytaj", "F8")));
        }

        skok1.text = "W";
        skok2.text = "Space";
        skok3.text = "UpArrow";
        left4.text = "A";
        left5.text = "LeftArrow";
        right6.text = "D";
        right7.text = "RightArrow";
        dol8.text = "DownArrow";
        dol9.text = "S";
        shift.text = "LeftControl";
        zapis.text = "F5";
        wczyt.text = "F8";

    }

    public void WyjdzZError()
    {
        error.SetActive(false);
        errorActiv = false;
    }

}
