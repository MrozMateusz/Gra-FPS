using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Strzelanie : MonoBehaviour
{

    public GameObject pocisk;

    Ray trafienie;

    float timer = 0.3f;
    float zasieg = 30.0f;
    float nastepny_strzal = 0f;

    // Use this for initialization
    void Start()
    {

        Cursor.visible = false;

    }

    void Update()
    {

        if (nastepny_strzal < timer)
        {
            nastepny_strzal += Time.deltaTime;
        }
        if (Czas_stop_koniec.czas_zatrzym_koniec == false)
        {
            strzal();
        }
        else
        {
            Time.timeScale = 0.0f;
        }
    }

    void strzal()
    {
        if (Input.GetButtonDown("Fire1") && nastepny_strzal >= timer)
        {

            nastepny_strzal = 0;

            trafienie = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            RaycastHit cel;

            if (Physics.Raycast(trafienie, out cel, zasieg))
            {
                Vector3 punkttrafienia = cel.point;

                GameObject go = cel.collider.gameObject;

               

                if (pocisk != null)
                {
                    Instantiate(pocisk, punkttrafienia, Quaternion.identity);
                }
            }

        }
    }

}


