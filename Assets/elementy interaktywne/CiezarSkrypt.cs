using UnityEngine;
using System.Collections;

public class CiezarSkrypt : ElementInteraktywnyZachowanie {


	protected override void Akcja()
	{ 
		transform.Find ("ciezar").rigidbody2D.isKinematic=false;

	}
}
