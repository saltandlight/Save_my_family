using UnityEngine;
using System.Collections;

public class MouseClickRight : MonoBehaviour {
	public float moveSpeed = 10f;
	void OnMouseDown ()
	{
		transform.Translate(Vector3.forward*moveSpeed * Time.deltaTime);
	}

}
