using UnityEngine;
using System.Collections;

public class Mustard : MonoBehaviour {
	public ParticleSystem Fire;
	private int count=0;

	void Update(){
		if(count==1)
			DestroyFire();
	}


	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag.Equals("Mustard Seed")) {
			Destroy (c.gameObject,.1f);
			count++;
		}
	}
	void DestroyFire() {
		if (Input.GetKey(KeyCode.Z) == true) 
			GameObject.Find("Fire").SetActive(false);
	}
}
