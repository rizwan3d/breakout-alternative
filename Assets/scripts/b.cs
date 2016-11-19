using UnityEngine;
using System.Collections;

public class b : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "ball")
			Destroy (this.gameObject);
	}
}
