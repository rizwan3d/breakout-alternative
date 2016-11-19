using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	[SerializeField]
	float speed = .09f;
	Rigidbody2D r;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "p")
			r.velocity  = new Vector2 (Random.Range(-2,2),speed);

	}
}
