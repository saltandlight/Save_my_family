using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	private int count = 0;
	public GameObject Prison1;
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag.Equals ("Key")) {
			Destroy (c.gameObject, .1f);
			count++;
		}
		if((count!=0)&&(c.gameObject.tag.Equals("Prison1"))){
			Destroy(Prison1,.1f);
		}
	}
}
