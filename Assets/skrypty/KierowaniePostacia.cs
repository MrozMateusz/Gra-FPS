using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KierowaniePostacia : MonoBehaviour {

    KeyCode Up, UpAlt, Skok, Left, LeftAlt, Right, RightAlt, Shift, Down, DownAlt;
    private CharacterController Cont;
    float wysokosc_skoku=4.5f;
    float aktualna_wyskosc=0.0f;
    float pr_biegu=8.0f;
    float pr_poruszania=8.0f;
    float czul_myszy = 3.0f;
    float zakres_myszy = 90.0f;
    float gora_dol = 0.0f;
    Vector3 ruch;

    // Use this for initialization
    void Start () {
        
        Cont = GetComponent<CharacterController>();

        if (PlayerPrefs.HasKey("Up"))
            Up = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up"));
        if (PlayerPrefs.HasKey("UpAlt"))
            UpAlt = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("UpAlt"));
        if (PlayerPrefs.HasKey("Skok"))
            Skok = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Skok"));
        if (PlayerPrefs.HasKey("Left"))
            Left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left"));
        if (PlayerPrefs.HasKey("LeftAlt"))
            LeftAlt = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("LeftAlt"));
        if (PlayerPrefs.HasKey("Right"))
            Right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right"));
        if (PlayerPrefs.HasKey("RightAlt"))
            RightAlt = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("RightAlt"));
        if (PlayerPrefs.HasKey("Shift"))
            Shift = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Shift"));
        if (PlayerPrefs.HasKey("Down"))
            Down = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down"));
        if (PlayerPrefs.HasKey("DownAlt"))
            DownAlt = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("DownAlt"));

        if(PlayerPrefs.GetInt("Klasa") == 1)
        {
            pr_poruszania = 10.0f;
        }
        else if(PlayerPrefs.GetInt("Klasa") == 2)
        {
            pr_poruszania = 8.0f;
        }
        else if(PlayerPrefs.GetInt("Klasa") == 3)
        {
            pr_poruszania = 6.0f;
        }




    }
	
	// Update is called once per frame
	void Update () {
        
            klaw();
            mause();
        
	}

    private void klaw()
{
    float Horizontal = Input.GetAxis("Horizontal") * pr_poruszania;
    float Vertical = Input.GetAxis("Vertical") * pr_poruszania;

    if (Czas_stop_koniec.czas_zatrzym_koniec == false)
    {
    if (Cont.isGrounded && Input.GetKey(Skok))
    {
        aktualna_wyskosc = wysokosc_skoku;
    }
    else if (!Cont.isGrounded)
    {
        aktualna_wyskosc += Physics.gravity.y * Time.deltaTime;
    }

    if (Cont.isGrounded && Input.GetKeyDown(Shift))
    {
        pr_poruszania += pr_biegu;
    }
    else if (Cont.isGrounded && Input.GetKeyUp(Shift))
    {
        pr_poruszania -= pr_biegu;
    }

            ruch = new Vector3(Horizontal, aktualna_wyskosc, Vertical);
        ruch = transform.rotation * ruch;
    
    

    Cont.Move(ruch * Time.deltaTime);
        }
        else
        {
            Time.timeScale = 0.0f;
        }
    }

    public void mause()
    {
        if (Czas_stop_koniec.czas_zatrzym_koniec == false)
        {
            float Lew_pr = Input.GetAxis("Mouse X") * czul_myszy;
            transform.Rotate(0, Lew_pr, 0);

            gora_dol -= Input.GetAxis("Mouse Y") * czul_myszy;

            gora_dol = Mathf.Clamp(gora_dol, -zakres_myszy, zakres_myszy);

            Camera.main.transform.localRotation = Quaternion.Euler(gora_dol, 0, 0);
        }
    }
}


