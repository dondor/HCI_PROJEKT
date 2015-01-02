using UnityEngine;
using System.Collections;

public class SankiSkrypt : ElementInteraktywnyZachowanie {

	// Use this for initialization
	protected override void Akcja()
	{ 
		transform.Find ("sanki").rigidbody2D.isKinematic=false;
		
	}
}
