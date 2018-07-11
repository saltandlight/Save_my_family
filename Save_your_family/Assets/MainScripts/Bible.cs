using UnityEngine;
using System.Collections;

public class Bible : MonoBehaviour {
	private int count = 0;
	private int boo1 = 0;
	public GameObject Dragon1;
	/*void Update(){
		if ((count ==1)&&(boo1 == 1))
			DestroyDragon();		
	}*/
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag.Equals ("Bible")) {
			Destroy (c.gameObject, .1f);
			count++;
		}


		
		if ((count != 0) && (c.gameObject.tag.Equals ("Dragon"))) {
				Destroy (c.gameObject, .1f);
		}
	}
}
