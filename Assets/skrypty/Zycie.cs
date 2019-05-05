using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zycie : MonoBehaviour
{
    static public int zycie = 100;
    public static int MaxZycie = 100;
    public GameObject kon;
    public int mozKon = 1;
    public Text text;
    public Text text2;


    // Start is called before the first frame update
    void Start()
    {
        zycie = PlayerPrefs.GetInt("ILZY");
        MaxZycie = PlayerPrefs.GetInt("ILZYM");
       
    }

    // Update is called once per frame
    void Update()
    {
        text.text = zycie.ToString();
        text2.text = MaxZycie.ToString();

        PlayerPrefs.SetInt("ILZY", zycie);
        
        if (zycie <= 0)
        {
            kon.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0.0f;
            mozKon = 0;
            PlayerPrefs.SetInt("MozKon", mozKon);

        }
        else
        {
            mozKon = 1;
            PlayerPrefs.SetInt("MozKon", mozKon);
        }
    }
    public void ObrazeniaotrzyGracz(int obrazenia)
    {
        zycie -= obrazenia;
    }

    public bool ZabicieGracza()
    {
        if (zycie <= 0)
        {
            return true;
        }
        return false;
    }
}
