using UnityEngine;
using System.Collections;

public class BalonSkrypt : ElementInteraktywnyZachowanie {

	// Use this for initialization

	protected override void Akcja()
	{
		transform.Find ("balon").rigidbody2D.gravityScale = -1;
	}

}
