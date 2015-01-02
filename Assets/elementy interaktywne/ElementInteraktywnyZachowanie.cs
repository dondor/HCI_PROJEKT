using UnityEngine;
using System.Collections;
//musialem tak zrobic bo niestety w przypadku predefiniowanych update i start dziedziczenie nei działa normalnie
public abstract class ElementInteraktywnyZachowanie : MonoBehaviour {

	protected KeyCode klawisz;
	// Use this for initialization
	protected	 void Start () {
		//Debug.Log ("wykonano funkcje start z bazowej klasy");
		for (int i =1;i<transform.childCount;i++) {
			Transform child=transform.GetChild(i);
			if (child.gameObject.tag == "emotka") {
			//	Debug.Log (child.name);

				switch(child.name)
			{case "usmiechPrefab":
						klawisz = KeyCode.U;
					break;
				case "zamknieciePrawegoOkaPrefab":
					klawisz=KeyCode.P;
					break;
				case "podniesioneBrwiPrefab":
					klawisz=KeyCode.B;
					break;
				case "zamkniecieLewegoOkaPrefab":
					klawisz = KeyCode.L;
					break;
				case "zamkniecieOczuPrefab":
					klawisz=KeyCode.O;
					break;
					break;
				default:
					break;
				}
						}
				}

	}
	
	protected 	void Update () {
		if (Input.GetKey (klawisz) == true) {
						Akcja ();

		}
	}
	protected abstract void Akcja();

}
