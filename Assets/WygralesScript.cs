using UnityEngine;
using System.Collections;

public class WygralesScript : MonoBehaviour {
	float postep=0;
	bool kolizja=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "piłka") {
				//		Debug.Log ("kolizja");
			kolizja = true;
			GameObject jakis = GameObject.FindGameObjectsWithTag ("czas")[0] ;

			jakis.guiText.enabled=true;
			jakis.guiText.text="0.0";
						//wyswietla postep
				}
	}
	void FixedUpdate()
	{
				if (kolizja == true) 
		{GameObject jakis = GameObject.FindGameObjectsWithTag ("czas") [0];
			if (postep <1)
			{//pierwsze dwie sekundy wyswietlamy czas, a potem napis zwyciestwo
						postep += Time.deltaTime;
						
						jakis.guiText.text = postep.ToString ("F1");
			}
						else {
								jakis.guiText.text = "Zwycięstwo";
						}
				}
		
				
	}

	void onTriggerStay2D(Collider2D other)
	{
	

		}
	void onTrigerExit2D(Collider2D other)
	{//Debug.Log ("koniec kolizji");
		postep = 0;
		kolizja = false;

		GameObject jakis = GameObject.FindGameObjectsWithTag ("czas")[0] ;
		
		jakis.guiText.enabled=false;
		}
}
