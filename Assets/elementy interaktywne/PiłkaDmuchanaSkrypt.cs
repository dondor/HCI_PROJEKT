using UnityEngine;
using System.Collections;

public class PiłkaDmuchanaSkrypt : ElementInteraktywnyZachowanie {

	protected int kierunek=0;
	public float szybkosc;
	public float wielkoscMaksymalna;
	private float postep = 0;
	void FixedUpdate()
	{

		 if (kierunek == 1) {
			if(postep <wielkoscMaksymalna)
			{
				transform.Find ("piłka").transform.localScale+=new Vector3(szybkosc,szybkosc,0);
			postep+=szybkosc;
			}

		}
		
		
	}
	protected override void Akcja()
	{
		Debug.Log ("wykryto klikniecie");
		kierunek = 1;
	}
}
