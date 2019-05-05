using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celownik : MonoBehaviour
{
    public Texture2D celownik;

    public Rect pozycja;

    public bool widoczny = true;
    // Start is called before the first frame update
    void Start()
    {
        pozycja = new Rect(
            (Screen.width - celownik.width) / 2,
            (Screen.height - celownik.height) / 2,
            celownik.width, celownik.height);
        
    }

    private void OnGUI()
    {
        if(widoczny == true)
        {
            GUI.DrawTexture(pozycja, celownik);
        }
    }
}
