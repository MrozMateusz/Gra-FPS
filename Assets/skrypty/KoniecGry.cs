using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KoniecGry : MonoBehaviour
{
    public Text wynikLicz;
    public Text czasLicz;
    public Text NickNapis;
    public Text klasa;

    private int wynik;
    private string nick;
    private int[] TablicaWynikow = new int[10];
    private string[] TablicaWynikowNick = new string[10];

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;

        wynikLicz.text = punktacja.wynik.ToString();
        czasLicz.text = CzasGry.CzasR;
        NickNapis.text = PlayerPrefs.GetString("NicK");

        if (PlayerPrefs.GetInt("Klasa") == 1)
        {
            klasa.text = "Zwiadowca";
        }
        else if(PlayerPrefs.GetInt("Klasa") == 2)
        {
            klasa.text = "Szturmowiec";
        }
        else if (PlayerPrefs.GetInt("Klasa") == 3)
        {
            klasa.text = "Zbrojny";
        }

        TablicaWynikow = PlayerPrefsX.GetIntArray("TablicaWynikow");
        TablicaWynikowNick = PlayerPrefsX.GetStringArray("TablicaWynikowNick");

        wynik = int.Parse(wynikLicz.text);
         nick = NickNapis.text.ToString();

        if (wynik > TablicaWynikow[9])
        { 
                for (int i = 0; i < 10; i++)
                {
                    if (wynik > TablicaWynikow[i])
                    {
                        for (int j = 9; j > i; j--)
                        {
                            TablicaWynikow[j] = TablicaWynikow[j - 1];
                            TablicaWynikowNick[j] = TablicaWynikowNick[j - 1];
                        }
                        TablicaWynikow[i] = wynik;
                        TablicaWynikowNick[i] = nick;
                        break;
                    }
                }

        }
        
        PlayerPrefsX.SetIntArray("TablicaWynikow", TablicaWynikow);
        PlayerPrefsX.SetStringArray("TablicaWynikowNick", TablicaWynikowNick);

    }

}
