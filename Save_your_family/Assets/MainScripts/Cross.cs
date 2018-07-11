using UnityEngine;
using System.Collections;

public class Cross : MonoBehaviour {
	public ParticleSystem Fire1;
	public ParticleSystem Fire2;
	public ParticleSystem Fire3;
	private int count=0;
	void Update(){
		if(count==1)
			DestroyFire();
	}


	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag.Equals("Cross")) {
			Destroy (c.gameObject,.1f);
			count++;
		}
	}

	void DestroyFire(){
		if (Input.GetKey (KeyCode.Z) == true) {
			GameObject.Find("Fire1").SetActive (false);
			GameObject.Find("Fire2").SetActive (false);
			GameObject.Find("Fire3").SetActive (false);
		}
	}
}
