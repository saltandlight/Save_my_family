using UnityEngine; using System.Collections; public class KeyInput : MonoBehaviour { 
	public float moveSpeed = 10f;
	void Update () { 
		bool left = Input.GetKeyDown(KeyCode.LeftArrow);
		bool right = Input.GetKey(KeyCode.RightArrow); 
		bool up = Input.GetKeyUp(KeyCode.UpArrow); 
		if(left) {
			transform.Translate(-Vector3.forward* moveSpeed * Time.deltaTime);
		}
		else if(right) {
			transform.Translate(Vector3.forward*moveSpeed * Time.deltaTime);        
		} 
		else if(up) { 
			transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
		}

	}
}