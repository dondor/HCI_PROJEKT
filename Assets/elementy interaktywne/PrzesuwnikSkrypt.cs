using UnityEngine;
using System.Collections;

public class PrzesuwnikSkrypt : ElementInteraktywnyZachowanie  {

	// Use this for initialization
	private float postep=0;
	public float szybkosc;
	protected int kierunek=0;
	//w kazdej klasie opisujacej elementy interaktywne funkcja start i update musi wygladac tak samo

	void FixedUpdate()
	{
		if (kierunek == 0) {
			
		} 
		else if (kierunek == 1) {
			
			transform.Find ("belka").rigidbody2D.MovePosition( new Vector2(
				transform.Find ("punktA").transform.position.x *(1-postep)+
				transform.Find ("punktB").transform.position.x *postep,
				
				transform.Find ("punktA").transform.position.y *(1-postep)+
				transform.Find ("punktB").transform.position.y *postep));
			
			postep+=szybkosc;
			if(postep>=1.0)
			{
				kierunek=0;
				postep=0.0f;
			}
		}
		
		
	}
	protected override void Akcja()
	{
		kierunek = 1;
	}
}
