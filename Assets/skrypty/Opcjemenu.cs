using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Opcjemenu : MonoBehaviour
{

    public Toggle FullScreen;
    public Dropdown rozdzielczosc;
    public Slider glosnosc;
    public Text rozText;
    public Text GrafText;
    private Resolution[] rozdzielczosci;
    private bool fs;

    // Start is called before the first frame update
    void Start()
    {
        
        rozdzielczosci = Screen.resolutions;

        FullScreen.isOn = Screen.fullScreen;

        glosnosc.value = AudioListener.volume;

        rozdzielczosc.ClearOptions();

        rozText.text = Screen.currentResolution.ToString();
    
        if(QualitySettings.GetQualityLevel() == 0)
        {
            GrafText.text = "Low";       
        }
        else if (QualitySettings.GetQualityLevel() == 1)
        {
            GrafText.text = "Medium";
        }
        else if (QualitySettings.GetQualityLevel() == 2)
        {
            GrafText.text = "High";
        }

        for (int i = 0; i < rozdzielczosci.Length; i++)
        {
            rozdzielczosc.options.Add(new Dropdown.OptionData());
            rozdzielczosc.options[i].text = RoztoString(rozdzielczosci[i]);

            if (RoztoString(rozdzielczosci[i]) == (Screen.width + "x" + Screen.height + "x" + rozdzielczosci[i].refreshRate))
            {
                rozdzielczosc.value = i;
            }
        }
        rozdzielczosc.RefreshShownValue();


        glosnosc.onValueChanged.AddListener(delegate { GlosnoscZmiana(); });
        FullScreen.onValueChanged.AddListener(delegate { FullScreenZmiana(); });
        rozdzielczosc.onValueChanged.AddListener(delegate { RozdzielczoscZmiana(); });
    }

    private void Update()
    {
        rozText.text = Screen.currentResolution.ToString();
        if (QualitySettings.GetQualityLevel() == 0)
        {
            GrafText.text = "Low";
        }
        else if (QualitySettings.GetQualityLevel() == 1)
        {
            GrafText.text = "Medium";
        }
        else if (QualitySettings.GetQualityLevel() == 2)
        {
            GrafText.text = "High";
        }
    }

        private void FixedUpdate()
    {
        fs = Screen.fullScreen;

        if (fs == true)
        {
            FullScreen.isOn = true;
        }
        else
        {
            FullScreen.isOn = false;
        }
        glosnosc.value = AudioListener.volume;

    }
    public void FullScreenZmiana()
    {
        if (FullScreen.isOn)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }
    public void GlosnoscZmiana()
    {
        AudioListener.volume = glosnosc.value;
    }

    public void RozdzielczoscZmiana()
    {
        Screen.SetResolution(int.Parse(StringToRoz(rozdzielczosc.options[rozdzielczosc.value].text)[0]), int.Parse(StringToRoz(rozdzielczosc.options[rozdzielczosc.value].text)[1]), FullScreen.isOn, int.Parse(StringToRoz(rozdzielczosc.options[rozdzielczosc.value].text)[2]));
    }

    string[] StringToRoz(string roz)
    {
        return roz.Split('x', 'H','z');
    }

    string RoztoString(Resolution roz)
        { 
            return roz.width + "x" + roz.height + " x "+ roz.refreshRate + "H" + "z";
        }

    public void GrafikaLow()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void GrafikaMed()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void GrafikaHigh()
    {
        QualitySettings.SetQualityLevel(2);
    }
}
