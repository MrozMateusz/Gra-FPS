using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float predkoscObrotu = 6.0f;


	public bool gladkiObrot = true;



	public float predkoscRuchu = 5.0f; 

	public float zasiegWzroku = 40.0f;

	public float odstepOdGracza = 5.0f;

	private Transform mojObiekt; 
	private Transform gracz;
	private GameObject graczObiekt;
	private bool patrzNaGracza = false;
	private Vector3 pozycjaGraczaXYZ; 

	// Use this for initialization
	void Start () {
		mojObiekt = transform;
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update() {
        if(Czas_stop_koniec.czas_zatrzym_koniec == false) { 

        graczObiekt = GameObject.FindWithTag("Player");
        gracz = graczObiekt.transform;


        pozycjaGraczaXYZ = new Vector3(gracz.position.x, mojObiekt.position.y, gracz.position.z);


        float dist = Vector3.Distance(mojObiekt.position, gracz.position);

        patrzNaGracza = false;


        if (dist <= zasiegWzroku && dist > odstepOdGracza && !Martwy()) {
            patrzNaGracza = true;


            mojObiekt.position = Vector3.MoveTowards(mojObiekt.position, pozycjaGraczaXYZ, predkoscRuchu * Time.deltaTime);

        } else if (dist <= odstepOdGracza && !Martwy()) {
            patrzNaGracza = true;
        }

        if (!Martwy())
        {
            patrzNaMnie();
        }

        }
        else
        {
            Time.timeScale = 0.0f;
        }
	}

	void patrzNaMnie(){
		if (gladkiObrot && patrzNaGracza == true){

			
			Quaternion rotation = Quaternion.LookRotation(pozycjaGraczaXYZ - mojObiekt.position);

			mojObiekt.rotation = Quaternion.Slerp(mojObiekt.rotation, rotation, Time.deltaTime * predkoscObrotu);

      
		} else if(!gladkiObrot && patrzNaGracza == true){ 
		

			transform.LookAt(pozycjaGraczaXYZ);
		}

	}

    bool Martwy()
    {
        Zdrowie zdr = gameObject.GetComponent<Zdrowie>();
        if(zdr != null)
        {
            return zdr.Zabicie();
        }
        return false;
    }

}

