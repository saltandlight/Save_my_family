using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class MoveObject : MonoBehaviour {
	public int moveSpeed = 5;
	private bool leftButton;
	private bool rightButton;
	private bool upButton;
	private bool downButton;
	void Start () {
		leftButton = false;
		rightButton = false;
		upButton = false;
		downButton = false;
	}
	void Update () {
		if (leftButton == true)
			gameObject.transform.Translate(-Vector3.forward* moveSpeed * Time.deltaTime);
		else if (rightButton == true)
			gameObject.transform.Translate(Vector3.forward*moveSpeed * Time.deltaTime);
		else if (upButton == true)
			gameObject.transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
		else if (downButton == true)
			gameObject.transform.Translate (Vector3.down * moveSpeed * Time.deltaTime);
	}

	public void JumpPlayer()
	{

		gameObject.GetComponent<Rigidbody> ().AddForce (transform.up * 200f);

	}

	public void ImageButtonDown(int i) {
		switch (i) {
		case 1: leftButton = true;
			break;
		case 2: rightButton = true;
			break;
		case 3: upButton = true;
			break;
		case 4: downButton = true;
			break;
		}
	}
	public void ImageButtonUp(int i) {
		switch (i) {
		case 1: leftButton = false;
			break;
		case 2: rightButton = false;
			break;
		case 3: upButton = false;
			break;
		case 4: downButton = false;
			break;
		}
	}
}