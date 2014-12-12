using UnityEngine;
using System.Collections;

public class SprezynaScript : ElementInteraktywnyZachowanie {

	protected override void Akcja()
	{
		//rigidbody2D.isKinematic = false;
		transform.Find ("platforma").rigidbody2D.isKinematic=false;
	}
}
