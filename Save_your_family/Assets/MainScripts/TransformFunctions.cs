using UnityEngine;
using System.Collections;
public class TransformFunctions : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	public CharacterController CC;
	public Animation Any;
	RaycastHit Hit;
	Quaternion dir;
	float Distancedir;
	Vector3 v1;
	Vector3 v2;

	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(-Vector3.forward* moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector3.forward*moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

	}
}