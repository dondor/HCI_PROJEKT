using UnityEngine;
using System.Collections;

public class ElementInteraktywnyZachowanie : MonoBehaviour {
	private float postep=0;
	public float szybkosc;
	private int kierunek=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftControl) == true)
			Akcja ();
	}
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
	void Akcja()
	{
		kierunek = 1;
	}
}
